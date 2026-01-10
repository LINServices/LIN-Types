param(
  [string]$Destination = "C:\Users\ASUS\Videos\nugets",
  [switch]$IncludeSymbols,
  [switch]$DryRun
)

Set-StrictMode -Version Latest
$ErrorActionPreference = "Stop"

$Root = Get-Location

# Crear destino si no existe
if (-not (Test-Path -LiteralPath $Destination)) {
  New-Item -ItemType Directory -Path $Destination | Out-Null
}

Write-Host "Raíz: $Root"
Write-Host "Destino: $Destination"
if ($DryRun) { Write-Host "[MODO PRUEBA] No se moverán archivos." }

# 1) Buscar paquetes por extensión (rápido y simple)
$patterns = @("*.nupkg")
if ($IncludeSymbols) { $patterns += "*.snupkg" }

$all = @()
foreach ($pat in $patterns) {
  $all += Get-ChildItem -Path $Root -Recurse -File -Filter $pat -ErrorAction SilentlyContinue
}

if (-not $all) {
  Write-Host "No se encontraron paquetes (.nupkg/.snupkg)."
  exit 0
}

# 2) Filtrar: solo los que estén dentro de bin\Release y NO dentro de .git/obj/node_modules
$sep = [IO.Path]::DirectorySeparatorChar
$rxBinRelease = [regex]"[\\/]bin[\\/]Release[\\/]"
$rxIgnored    = [regex]"[\\/]\.git[\\/]|[\\/]obj[\\/]|[\\/]node_modules[\\/]"

$found = $all | Where-Object {
  $rxBinRelease.IsMatch($_.FullName) -and -not $rxIgnored.IsMatch($_.FullName)
}

if (-not $found) {
  Write-Host "No se encontraron paquetes dentro de bin${sep}Release (o todos estaban en rutas ignoradas)."
  exit 0
}

Write-Host "Paquetes encontrados: $($found.Count)"

# 3) Mover (o simular)
$counter = 0
foreach ($file in $found) {
  $targetPath = Join-Path $Destination $file.Name

  # Evitar sobrescribir: agregar sufijo _1, _2, ...
  if (Test-Path -LiteralPath $targetPath) {
    $name = [IO.Path]::GetFileNameWithoutExtension($file.Name)
    $ext  = [IO.Path]::GetExtension($file.Name)
    $i = 1
    do {
      $candidate = Join-Path $Destination ("{0}_{1}{2}" -f $name, $i, $ext)
      $i++
    } while (Test-Path -LiteralPath $candidate)
    $targetPath = $candidate
  }

  if ($DryRun) {
    Write-Host "[PRUEBA] Mover: '$($file.FullName)' -> '$targetPath'"
  } else {
    Move-Item -LiteralPath $file.FullName -Destination $targetPath
    Write-Host "Movido: '$($file.FullName)' -> '$targetPath'"
    $counter++
  }
}

if (-not $DryRun) {
  Write-Host "✅ Listo. Paquetes movidos: $counter"
} else {
  Write-Host "✅ Simulación completada (ningún archivo movido)."
}
