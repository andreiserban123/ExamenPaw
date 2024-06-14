namespace subiect7 {
    public class Algoritmi {
        // Metoda 1: Plată fixă pe lună
        public static double[] DesfasuratorRateDescrescatoare(Credit credit) {
            int n = credit.Perioada;
            double[] platiLunare = new double[n];
            double sumaRamas = credit.ValoareCredit;
            double principalPlatit = credit.ValoareCredit / n;

            for (int i = 0; i < n; i++) {
                double dobandaLunara = sumaRamas * (credit.Dobanda / 100) / 12;
                platiLunare[i] = principalPlatit + dobandaLunara;
                sumaRamas -= principalPlatit;
            }

            return platiLunare;
        }

        // Metoda 2: Desfasurator Rate Constante
        public static double[] DesfasuratorRateConstante(Credit credit) {
            int n = credit.Perioada;
            double[] platiLunare = new double[n];
            double dobandaTotala = credit.ValoareCredit * (credit.Dobanda / 100) * (credit.Perioada / 12);
            double valoareTotala = credit.ValoareCredit + dobandaTotala;
            double plataLunara = valoareTotala / n;

            for (int i = 0; i < n; i++) {
                platiLunare[i] = plataLunara;
            }

            return platiLunare;
        }


    }

}
