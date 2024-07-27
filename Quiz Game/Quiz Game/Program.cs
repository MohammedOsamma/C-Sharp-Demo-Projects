namespace Quiz_Game
{
    internal class Program
    {
     
        static void Main(string[] args)
        {
            string[] questions = new string [3]
            {
                "What is the red planet ?",
                "What is the largest animal ?",
                "What is the Capital of italy ? "
           };
            string[] answers = new string[3]
            {
                "Mars",
                "Whale",
                "Roma"
          };
           int correctAnswer = 0;

            Console.WriteLine("Welcome in Quiz Game :)");
            Console.WriteLine("Please answar on the questions");

            for (int i = 0;i < questions.Length; i++)
            {
                Console.WriteLine(questions[i]);
                var userInput = Console.ReadLine();

                try
                {
                    var result = IsTheAnswerCorrect(userInput, answers[i]);

                    if (result)
                    {
                        Console.WriteLine("The answer is Correct ");
                        correctAnswer++;
                    }
                    else
                    {
                        Console.WriteLine($"Sorry the answer is incorrect ,the correct answer is : {answers[i]} ");
                    }
                }
               catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                

            }

            Console.WriteLine("----------------------------------------------------");

            Console.WriteLine($"Your score is : {correctAnswer}");
            Console.WriteLine("Quiz game is completed , Thank you for playing :)");



        }

        private static bool IsTheAnswerCorrect (string userInput ,string correctAnswer)
        {
            if (String.IsNullOrEmpty(userInput))
            {
                throw new Exception("Yout answer is empty");
            }
          
            if (userInput.Equals(correctAnswer, StringComparison.OrdinalIgnoreCase))
            {
                
                return true;
            }
            else
            {
              
                return false;
            }
        }
   
    }
}
