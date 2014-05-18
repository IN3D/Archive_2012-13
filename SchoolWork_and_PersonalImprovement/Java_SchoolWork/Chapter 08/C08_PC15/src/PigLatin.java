public class PigLatin {

    private String convertMe;


    public PigLatin() {
        this.convertMe = "pig latin is the best language ever";
    }

    public PigLatin(String convertMe) {
        this.convertMe = convertMe;
    }

    public void pigLatinize() {
        String[] tokens = convertMe.split(" ");
        char buffer;

        for (String s : tokens) {
            buffer = s.charAt(0);

            StringBuilder sb = new StringBuilder(s);
            sb.insert(sb.length(),(buffer + "ay"));
            sb.deleteCharAt(0);
            System.out.print(sb.toString().toUpperCase() + " ");
        }
        System.out.println();
    }

}
