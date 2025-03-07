using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rabbit.library.books.domain.Abstractions;
public class Entity<T> : IEntity<T>
{
  public T Id { get; set; }
  public DateTime? CreateAt { get; set; }
  public DateTime? LastModified { get; set; }
  public string? CreatedBy { get; set; }
  public string? LastModifiedBy { get; set; }
}