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

        [DllImport("rush.dll", EntryPoint = "rush_execute")]
        public static extern int RushExecute(string input);
#elif LINUX
        const string NativeLibrary = "Native/libtypst_ffi.so";

        JavaSystem.LoadLibrary("rush");

#elif IOS
        [DllImport("__Internal", EntryPoint = "rush_execute")]
        public static extern int RushExecute(string input);
#elif MACOS
        private const string NativeLibrary = "Native/libtypst_ffi.dylib";
else
        using System.Runtime.InteropServices.JavaScript;

        [JSImport("rush_execute", "rush.wasm")]
        public static partial int RushExecute(string input);

        using Wasmtime;

        using var engine = new Engine();
        using var module = Module.FromFile(engine, "rush.wasm");
        using var linker = new Linker(engine);
        using var store = new Store(engine);
        using var instance = linker.Instantiate(store, module);

        var func = instance.GetFunction("rush_execute");
        func?.Invoke("input data");
#endif

        //[DllImport(NativeLibrary, EntryPoint = "add_numbers", ExactSpelling = true, CallingConvention = CallingConvention.Cdecl)]
        //private static extern Int32 add_numbers(Int32 number1, Int32 number2);

        //public static int AddNumbers(int number1, int number2)
        //{
        //    return add_numbers(number1, number2);
        //}
    }
}
