using System.ComponentModel.DataAnnotations.Schema;

namespace RestApiAuthenticationJwt.Model.Base
{
    public class BaseEntity
    {
        [Column("id")]
        public long Id { get; set; }
    }
}
