namespace Params_ref_e_out {
    class Calculator {
        /*ref
        public static void Triple(ref int x) {
            x = x * 3;
        }
        */

        public static void Triple(int origin, out int result) {
            result = origin * 3;
        }
    }
}
