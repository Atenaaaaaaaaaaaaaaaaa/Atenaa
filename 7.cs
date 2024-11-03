
string input = "Hello, my phone number is 0123456789, my address is rue Voltaire 145. " +
"the number 1234567890 is not valid anymore. Contact the number 0147258369 if you have any question " +
"the number 012345678 is not valid anymore. Contact the number 0999999888 if you have any question 0999999999 " +
"Our customer care representatives are available to assist you 24 hours a day, 7 days a week on : 0000000000, 9999999999 and 0777778899";

string[] words = input.Split(' ');


for (int j = 0; j < words.Length; j++)
{
    string word = words[j];

    if (word.Length == 10 && word.StartsWith("0"))
    {
        bool isdigit = true;
        for (int i = 0; i < word.Length; i++)
        {
            if (!char.IsDigit(word[i]))
            {
                isdigit = false;
                i = word.Length; 
            }
        }

        if (isdigit)
        {
            char firstdigit = word[0];
            bool isdifferent = false;

            for (int i = 1; i < word.Length; i++)
            {
                if (word[i] != firstdigit)
                {
                    isdifferent = true;
                    i = word.Length;
                }
            }

            if (isdifferent)
            {
                Console.WriteLine(word);
            }
        }
    }
}
