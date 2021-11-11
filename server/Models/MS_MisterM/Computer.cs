using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MisterM.Models.MsMisterM
{
  [Table("Computers", Schema = "dbo")]
  public partial class Computer
  {
    public string mac
    {
      get;
      set;
    }
    public string name
    {
      get;
      set;
    }
    public string model
    {
      get;
      set;
    }
    public float? temperature
    {
      get;
      set;
    }
  }
}
