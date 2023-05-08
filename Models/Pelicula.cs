using PARCIAL_1.Utils;
using System.ComponentModel.DataAnnotations;
namespace PARCIAL_1.Models;


public class Pelicula {

public int Id { get; set; }

[Required]
[Display(Name = "Nombre Pelicula")]
public string Name { get; set; }

[Required]
[Display(Name = "Año de Realizacion")]
public int Año { get; set; }

[Display(Name = "Actor")]
public int ActorId {get; set; }

public virtual Actor Actor {get; set; }







}