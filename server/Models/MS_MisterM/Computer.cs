using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MisterM.Models.MS_MisterM
{
  [Table("Computers", Schema = "dbo")]
  public partial class Computer
  {
    [Key]
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
