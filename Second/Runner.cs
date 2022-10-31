using System.Collections;

namespace Game{
    class Runner{
        public static void Main(){
            TrainingGame trainingGame = new TrainingGame();
            // trainingGame.logicGame();
           string test = "2 - 20";
           string[] testArr = test.Split(" ");
           for (int i = 0; i < testArr.Length; i++){
            System.Console.Write(testArr[i] + " ");
           }
           System.Console.WriteLine("num1 = {0} num2 = {1} sum = {2}", Int32.Parse(Convert.ToString(testArr[0])), Int32.Parse(Convert.ToString(testArr[2])), (Int32.Parse(Convert.ToString(testArr[0])) + Int32.Parse(Convert.ToString(testArr[2]))));
        //     try{
        //         int numVal = Int32.Parse(Convert.ToString(test[0]));
        //         int numVal2 = Int32.Parse(Convert.ToString(test[2]));

        //         System.Console.WriteLine("sum = " + (numVal+numVal2));
        //     }
        //     catch (FormatException e){
        //         Console.WriteLine(e.Message);
        //     }
        }
    }
}