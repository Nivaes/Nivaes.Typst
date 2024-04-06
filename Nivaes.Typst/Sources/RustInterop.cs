using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Diagnostics.CodeAnalysis;

namespace Nivaes.Typst
{
    public class RustInterop
    {
#if AOT
        const string NativeLibrary = "*";
#elif WINDOWS
        private const string NativeLibrary = "Native/typst_ffi.dll";
#elif LINUX
        const string NativeLibrary = "Native/libtypst_ffi.so";
#elif MACOS
        private const string NativeLibrary = "Native/libtypst_ffi.dylib";
#endif

        [DllImport(NativeLibrary, EntryPoint = "add_numbers", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        private static extern Int32 add_numbers(Int32 number1, Int32 number2);

        public static int AddNumbers(int number1, int number2)
        {
            return add_numbers(number1, number2);
        }
    }
}
