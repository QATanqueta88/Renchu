using PARCIAL_1.Utils;
namespace PARCIAL_1.Models;


public class Actor {

public int Id { get; set; }

public string Name { get; set; }

public string Surname{ get; set; }

public int Edad { get; set; }

public string Mail { get; set; }

public ActorType Type { get; set; }

public bool Experience { get; set;} = false;





}