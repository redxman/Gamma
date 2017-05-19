using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Abp.Web.Mvc.Controllers;
using Gamma.Core;

namespace Gamma.Web.Controllers
{
    /// <summary>
    /// 控制器均继承此抽象类，可以放置公用方法
    /// </summary>
    public abstract class GammaControllerBase : AbpController
    {
        protected GammaControllerBase()
        {
            LocalizationSourceName = GammaConsts.LocalizationSourceName;
        }
        
    }
}