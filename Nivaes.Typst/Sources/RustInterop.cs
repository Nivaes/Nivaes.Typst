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
        [DllImport("./Native/typst_ffi", EntryPoint = "add_numbers")]
        private static extern Int32 add_numbers(Int32 number1, Int32 number2);

        public static int AddNumbers(int number1, int number2)
        {
            return add_numbers(number1, number2);
        }
    }
}
