namespace CompararNumeros {
    public static class CompararNumero {

        public static bool MaiorNumero(int n1, int n2) {

            if (n1 > n2)
                return true;

            else return false;
        }

        public static bool MenorNumero(int n1, int n2) {

            if (n2 < n1)
                return false;

            else return true;
        }

        public static bool SemNumeroMaior(int n1, int n2, int n3) {

            if (n1 == n3   &&  n1 != n2)
                return true;
            else return false;
        }

    }
}
