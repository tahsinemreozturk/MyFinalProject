using Business.Constants;
using Castle.DynamicProxy;
using Core.Extensions;
using Core.Utilities.Interceptors;
using Core.Utilities.IoC;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Business.BussinesAspects.Autofac
{
    public class SecuredOperation : MethodInterception
    {
        //SecuredOperation JWT icin.
        private string[] _roles;
        //IHttpContextAccessor HTTP isteğine erişim sağlamak ve bu isteğe ilişkin bilgileri almak için kullanılır.
        private IHttpContextAccessor _httpContextAccessor;

        public SecuredOperation(string roles)
        {
            //roles.Split ile bir metni benim belirtigim karaktere gore, ayirip array`e atiyoruz. Attiributte kullanimi icin bu gereklidir.
            _roles = roles.Split(',');
            _httpContextAccessor = ServiceTool.ServiceProvider.GetService<IHttpContextAccessor>();

        }

        protected override void OnBefore(IInvocation invocation)
        {
            var roleClaims = _httpContextAccessor.HttpContext.User.ClaimRoles();
            foreach (var role in _roles)
            {
                if (roleClaims.Contains(role))
                {
                    return;
                }
            }
            throw new Exception(Messages.AuthorizationDenied);
        }
    }
}
