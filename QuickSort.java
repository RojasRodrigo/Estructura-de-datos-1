public class QuickSort {

    // Método principal de ordenamiento
    public static void quickSort(int[] arr, int inicio, int fin) {
        if (inicio < fin) {
            int indicePivote = particion(arr, inicio, fin);

            // Ordenar izquierda del pivote
            quickSort(arr, inicio, indicePivote - 1);

            // Ordenar derecha del pivote
            quickSort(arr, indicePivote + 1, fin);
        }
    }

    // Método para ubicar el pivote en su posición correcta
    public static int particion(int[] arr, int inicio, int fin) {
        int pivote = arr[fin]; // tomamos el último elemento como pivote
        int i = inicio - 1;

        for (int j = inicio; j < fin; j++) {
            if (arr[j] < pivote) {
                i++;

                // Intercambio
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }

        // Colocar el pivote en su posición final
        int temp = arr[i + 1];
        arr[i + 1] = arr[fin];
        arr[fin] = temp;

        return i + 1;
    }

    // Método para imprimir el arreglo
    public static void imprimir(int[] arr) {
        for (int num : arr) {
            System.out.print(num + " ");
        }
        System.out.println();
    }

    // Método main para probar
    public static void main(String[] args) {
        int[] datos = { 8, 3, 1, 7, 0, 10, 2 };

        System.out.println("Arreglo original:");
        imprimir(datos);

        quickSort(datos, 0, datos.length - 1);

        System.out.println("Arreglo ordenado:");
        imprimir(datos);
    }
}