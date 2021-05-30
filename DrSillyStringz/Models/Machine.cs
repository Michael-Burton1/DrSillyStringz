using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Machine
  {
    public Machine()
    {
      this.JoinEntities = new HashSet<EngineerMachine>();
    }
    [Required]
    public int MachineId { get; set; }
    [Required]
    public string Name { get; set; }
    public float Cost {get; set;}
    [Required]
    public DateTime DateRecived {get; set;}
    
    public virtual ICollection<EngineerMachine> JoinEntities { get;}
  }
}