using LIN.Shared.Enumerations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LIN.Shared.Models;


/// <summary>
/// Model de 'ContactDataModel'
/// </summary>
public class ContactDataModel
{

    public int ID { get; set; } = 0;

    [Column("IMAGEN")]
    public byte[] Picture { get; set; } = Array.Empty<byte>();

    [Column("NOMBRE")]
    public string Name { get; set; } = string.Empty;

    [Column("TELEFONO")]
    public string Phone { get; set; } = string.Empty;

    [Column("CORREO")]
    public string Mail { get; set; } = string.Empty;

    [Column("DIRECCION")]
    public string Direction { get; set; } = string.Empty;

    [Column("ESTADO")]
    public ContactStatus State { get; set; } = ContactStatus.Normal;

    [Column("USUARIO_FK")]
    public int UserID { get; set; } = -1;



    public void FillWith(ContactDataModel model)
    {
        ID = model.ID;
        Picture = model.Picture;
        Name = model.Name;
        Phone = model.Phone;
        Mail = model.Mail;
        Direction = model.Direction;
        State = model.State;
        UserID = model.UserID;
    }




}
