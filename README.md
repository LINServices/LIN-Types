# LCEE - LIN Communication Externals Standard  

**Versión:** 4.0   
**Autor:** LIN Platform  

## 📌 Introducción  

LCEE (**LIN Communication Externals Standard**) es un estándar de comunicación diseñado para garantizar la **consistencia, estabilidad y retrocompatibilidad** en la interacción entre aplicaciones dentro de LIN Platform.  

Este estándar es utilizado por LIN Platform, incluyendo APIs, aplicaciones web, Android y Windows.  

## 📦 Instalación  

LCEE se distribuye como una **librería NuGet**. Para instalarla en tu aplicación, usa el siguiente comando en la terminal:  



## 🚀 Principios del Estándar
- ✔ No Breaking Changes: Todas las mejoras deben ser compatibles con versiones anteriores.
- ✔ Estructura Unificada: Todas las respuestas siguen el mismo formato.
- ✔ Manejo Consistente de Errores: Siempre se devuelve un Status, incluso en fallos críticos.
- ✔ Mapeo a HTTP Status Codes: Compatible con APIs REST.
- ✔ Uso en Microservicios: Adaptado a la arquitectura de LIN Platform.


## 📌 Tipos de Respuesta en LCEE
LCEE define varios tipos de respuesta, todos basados en una estructura común que garantiza consistencia y
facilidad de manejo en las aplicaciones de LIN Platform. Todas las respuestas heredan de BaseResponse, 
lo que permite que compartan propiedades fundamentales como el estado (Status), errores y mensajes adicionales.

1️⃣ BaseResponse (Clase Base para Todas las Respuestas)
Es la estructura base de todas las respuestas en LCEE. Contiene información sobre el estado de la operación y posibles errores.

📌 Propiedades:

- **Status**: Indica el estado de la respuesta, por ejemplo, si la operación fue exitosa o hubo un error.
- **ErrorList**: Lista de errores en caso de que la operación haya fallado.
- **Message**: Un mensaje adicional con información sobre la respuesta.
- **AlternativeObject**: Un objeto opcional para incluir información alternativa.

2️⃣ CreateResponse (Respuesta para Creación de Datos)
Este tipo de respuesta se utiliza cuando una operación crea un nuevo registro en la base de datos.

📌 Propiedades adicionales:

- **LastId**: Representa el identificador del último registro creado.
LastUnique: Es un identificador único asignado al nuevo registro.
- 📌 Ejemplo de uso:
Si un usuario crea una nueva cuenta, la respuesta incluirá el LastId con el ID del usuario recién creado y LastUnique con un identificador único.

3️⃣ **ReadAllResponse** (Respuesta para Obtener Múltiples Datos)
Se usa cuando se realiza una consulta que devuelve una lista de elementos.

📌 Propiedades adicionales:

**Models**: Contiene la lista de objetos recuperados de la base de datos.

 📌 Ejemplo de uso:
Si una aplicación solicita una lista de usuarios, Models contendrá los datos de todos los usuarios registrados.

4️⃣ ReadOneResponse (Respuesta para Obtener un Solo Registro)
Se utiliza cuando se necesita recuperar un solo elemento de la base de datos.

📌 Propiedades adicionales:

**Model**: Contiene el objeto solicitado.
📌 Ejemplo de uso:
Si una aplicación busca la información de un usuario específico, Model contendrá los datos de ese usuario.

📌 Resumen de Uso

| Tipo de Respuesta | Propósito |
|----------|----------|
| BaseResponse		 | Clase base para todas las respuestas   | 
| CreateResponse     | Responde cuando se crea un nuevo registro   | 
| ReadAllResponse    | Devuelve una lista de registros   | 
| ReadOneResponse    | Devuelve un solo registro   | 



🔄 Lista de Status
Cada Status representa un estado de la respuesta y se mapea a un código HTTP correspondiente.

| Status                 | Código HTTP | Descripción                            |
|------------------------|------------|----------------------------------------|
| Undefined             | 500        | Error indefinido                      |
| Success               | 200        | Operación exitosa                     |
| NotConnection         | 503        | Sin conexión                          |
| NotExistAccount       | 404        | Cuenta no existe                      |
| ExistAccount          | 409        | Cuenta ya existe                      |
| LockAccount           | 423        | Cuenta bloqueada                      |
| DisableAccount        | 403        | Cuenta desactivada                    |
| InvalidParam          | 400        | Parámetro inválido                    |
| NotRows               | 404        | No hay columnas que mostrar           |
| PasswordShort         | 400        | Contraseña demasiado corta            |
| InvalidUser           | 400        | Usuario inválido                      |
| NotExistProfile       | 404        | Perfil no existe                      |
| WithoutCredits        | 402        | Sin créditos                          |
| Unauthorized          | 401        | No autorizado                         |
| InvalidApiKey         | 401        | API Key inválida                      |
| FirewallBlocked       | 403        | Bloqueado por firewall                |
| InvalidPassword       | 401        | Contraseña inválida                   |
| UnavailableService    | 503        | Servicio no disponible                |
| UnauthorizedByOrg     | 403        | No autorizado por la organización     |
| LoginBlockedByOrg     | 403        | Login bloqueado por la organización   |
| InsufficientStorage   | 507        | Espacio insuficiente                  |
| UnauthorizedByApp     | 403        | Aplicación no autorizada              |
| NotFoundDirectory     | 404        | Directorio no encontrado              |
| PoliciesNotComplied   | 403        | No cumple con las políticas           |
| IsLoading            | 102        | Cargando                              |
| ResourceExist        | 409        | Recurso ya existe                     |
| ClosedStream (Obsoleto) | -      | Flujo cerrado (ya no en uso)          |
| RateLimitExceeded     | 429        | Límite de solicitudes excedido        |


## 📌 Nota:
Los Status obsoletos siguen funcionando por compatibilidad, pero no se recomienda su uso en nuevas implementaciones.

## 🛠️ Cómo Contribuir
Si necesitas proponer un nuevo Status o realizar mejoras en el estándar:

Crea un issue en este repositorio explicando tu propuesta.
Se revisará si la actualización es útil para más de un contexto.
Si se aprueba, se incluirá en la próxima actualización.