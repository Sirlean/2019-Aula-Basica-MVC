using System.Web;
using System.Web.Mvc;

namespace Meu.Projeto.Teste.MVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
