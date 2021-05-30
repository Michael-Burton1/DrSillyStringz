using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Engineer
  {
    public Engineer()
    {
      this.JoinEntities = new HashSet<EngineerMachine>();
    }
    [Required]
    public int EngineerId { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Status { get; set; }
    public virtual ICollection<EngineerMachine> JoinEntities { get; set; }
  }
}