namespace DotNetCource.MainConstructions
{
    public static class PrimitiveTypes
    {
        public static bool Variable1 { get; set; }
        //-128 to 127
        public static sbyte Variable2 { get; set; }
        // 0 to 255
        public static byte Variable3 { get; set; }
        // -32 768 to 32 767
        public static short Variable4 { get; set; }
        // 0 to 65 535
        public static ushort Variable5 { get; set; }
        // - 2 147 483 648 to 2 147 483 647 
        public static int Variable6 { get; set; } = 5;
        // 0 to 4 294 967 295
        public static uint Variable7 { get; set; }
        //  -9 223 372 036 854 775 808 to 9 223 372 036 854 775 807
        public static long Variable8 { get; set; } = 10L;
        // 0 to 18 446 744 073 709 551 615
        public static ulong Variable9 { get; set; }
        // U+0000 to U+ffff
        public static char Variable10 { get; set; }
        // -3.4х10^38 to +3.4х10^38
        public static float Variable11 { get; set; } = 10.3F;
        // ±5.0х10^324 to ±1.7х10^308
        public static double Variable12 { get; set; } = 10.5;
        //  -7.9х10^28 to 7.9х10^28
        public static decimal Variable13 { get; set; } = 10.3M;
        //unicode symbols
        public static string Variable14 { get; set; }
        public static object Variable15 { get; set; }
        public static dynamic Variable16 { get; set; }
    }
}