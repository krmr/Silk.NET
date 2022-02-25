using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using static Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.DXVA
{
    public partial class DXVA
    {
        public static DXVA GetApi()
        {
             return new(CreateDefaultContext(new DXVA2LibraryNameContainer().GetLibraryName()));
        }
    
        public bool TryGetExtension<T>(out T ext)
            where T:NativeExtension<DXVA>
        {
             ext = IsExtensionPresent(GetExtensionAttribute(typeof(T)).Name)
                 ? (T) Activator.CreateInstance(typeof(T), Context)
                 : null;
             return ext is not null;
        }
    
        public override bool IsExtensionPresent(string extension)
        {
            throw new NotImplementedException();
        }
    }
}
