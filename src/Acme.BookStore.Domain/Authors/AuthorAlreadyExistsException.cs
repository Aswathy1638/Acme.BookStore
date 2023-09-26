using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Volo.Abp;

namespace Acme.BookStore.Author
{
  public class AuthorAlreadyExistsException : BusinessException
    {
        public AuthorAlreadyExistsException(string name):base (BookStoreDomainErrorCodes.AuthorAlreadyExists)
        { 
         
        WithData("name", name);
    

        }
    }
}
