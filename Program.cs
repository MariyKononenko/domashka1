
double[] GenerateArray(int size, int leftRange, int rightRange){
double[] array = new double[size];
    Random rand = new Random();        
    for( int i = 0; i< size; i++){
        array[i] = Math.Round(rand.Next(leftRange, rightRange+1)+rand.NextDouble(), 3);
    }
    return array;
}



void PrintArray(double[]arrayForPrint){
    for(int i = 0; i<arrayForPrint.Length; i++)
        Console.Write(arrayForPrint[i]+" "); 
        Console.WriteLine("");
    

}

 int NumberMin (double[] array){
    int min = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]<min){
            min = i;
        }
    }
        return min;  
    
 }
 int NumberMax (double[] array){
    int max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>max){
            max = i;
        }
    }
        return max;  
    
 }

    double[] myArray = GenerateArray(10, 1, 100);
    PrintArray(myArray);
    int maxi = NumberMax(myArray);
    int mini = NumberMin(myArray);

Console.Write(myArray[maxi]-myArray[mini]);  
              

     
            
    

        