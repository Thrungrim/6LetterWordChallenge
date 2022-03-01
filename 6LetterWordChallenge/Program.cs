
const string path = @"C:\Users\lukah\source\repos\6LetterWordChallenge\6LetterWordChallenge\input.txt";

using (StreamReader file = new StreamReader(path))
{
    List<String> output = new List<String>();
    List<String> distinctOutput = new List<String>();
    string lineOfText;
    string checkword;
    const int maxLength = 6;
    while ((lineOfText = file.ReadLine()) != null)
    {
        if(lineOfText.Length == maxLength)
        {
            List<String> allWordsThatContainLettersOf6LetterWord = new List<String>();
            
            using(StreamReader inputToCheck = new StreamReader(path))
            {
                while ((checkword = inputToCheck.ReadLine()) != null)
                {
                    if (lineOfText.Contains(checkword))
                    {
                        allWordsThatContainLettersOf6LetterWord.Add(checkword);
                    }
                }

                foreach (string frontSide in allWordsThatContainLettersOf6LetterWord)
                {
                    foreach (string backSide in allWordsThatContainLettersOf6LetterWord)
                    {
                        if ((frontSide + backSide).Equals(lineOfText))
                        {
                            output.Add(frontSide + "+" + backSide + "=" + lineOfText);
                        }
                    }
                }
            }
            

        }  
    }
    distinctOutput = output.Distinct().ToList();
    foreach (string val in distinctOutput)
    {
        Console.WriteLine(val);
    }
}