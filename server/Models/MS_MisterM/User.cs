using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MisterM.Models.MsMisterM
{
  [Table("Users", Schema = "dbo")]
  public partial class User
  {
    public string id
    {
      get;
      set;
    }
    public string username
    {
      get;
      set;
    }
    public string email
    {
      get;
      set;
    }
  }
}
