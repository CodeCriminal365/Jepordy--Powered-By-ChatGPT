namespace Namespace {
    
    using random;
    
    using System.Collections.Generic;
    
    using System.Linq;
    
    public static class Module {
        
        public static object score = 0;
        
        public static object intro() {
            var readme = open("readme.txt", "r");
            Console.WriteLine("             Intro              ");
            Console.WriteLine("================================");
            Console.WriteLine(" ");
            Console.WriteLine(readme.read());
            Console.WriteLine(" ");
            Console.WriteLine("================================");
        }
        
        public static object credits() {
            Console.WriteLine(" ");
            Console.WriteLine("Your Score Is:", score, "Out Of 24 Questions!");
            var credits = open("credits.txt", "r");
            Console.WriteLine(" ");
            Console.WriteLine(credits.read());
            Console.WriteLine(" ");
            Console.WriteLine("================================");
        }
        
        public static object categories = new Dictionary<object, object> {
            {
                "History",
                new List<object> {
                    new Dictionary<object, object> {
                        {
                            "question",
                            "What year did World War I start?"},
                        {
                            "answer",
                            "1914"}},
                    new Dictionary<object, object> {
                        {
                            "question",
                            "Who was the first president of the United States?"},
                        {
                            "answer",
                            "George Washington"}},
                    new Dictionary<object, object> {
                        {
                            "question",
                            "What year did the American Civil War end?"},
                        {
                            "answer",
                            "1865"}}
                }},
            {
                "Science",
                new List<object> {
                    new Dictionary<object, object> {
                        {
                            "question",
                            "This famous physicist developed the theory of relativity."},
                        {
                            "answer",
                            "Albert Einstein"}},
                    new Dictionary<object, object> {
                        {
                            "question",
                            "What is the largest planet in our solar system?"},
                        {
                            "answer",
                            "Jupiter"}},
                    new Dictionary<object, object> {
                        {
                            "question",
                            "What is the smallest bone in the human body?"},
                        {
                            "answer",
                            "Stapes"}},
                    new Dictionary<object, object> {
                        {
                            "question",
                            "What is the symbol for the element oxygen?"},
                        {
                            "answer",
                            "O"}},
                    new Dictionary<object, object> {
                        {
                            "question",
                            "This is the largest animal in the world."},
                        {
                            "answer",
                            "Blue Whale"}}
                }},
            {
                "Geography",
                new List<object> {
                    new Dictionary<object, object> {
                        {
                            "question",
                            "What is the capital of Japan?"},
                        {
                            "answer",
                            "Tokyo"}},
                    new Dictionary<object, object> {
                        {
                            "question",
                            "What is the largest country in the world?"},
                        {
                            "answer",
                            "Russia"}},
                    new Dictionary<object, object> {
                        {
                            "question",
                            "What is the smallest continent?"},
                        {
                            "answer",
                            "Australia"}},
                    new Dictionary<object, object> {
                        {
                            "question",
                            "The Great Barrier Reef is located off the coast of this country."},
                        {
                            "answer",
                            "Australia"}},
                    new Dictionary<object, object> {
                        {
                            "question",
                            "What is the smallest country in the world by land area."},
                        {
                            "answer",
                            "Vatican City"}},
                    new Dictionary<object, object> {
                        {
                            "question",
                            "In which city would you find the famous statue of Christ the Redeemer?"},
                        {
                            "answer",
                            "Rio de Janeiro"}},
                    new Dictionary<object, object> {
                        {
                            "question",
                            "This American city is known as the 'City of Brotherly Love.'"},
                        {
                            "answer",
                            "Philadelphia"}}
                }},
            {
                "Games",
                new List<object> {
                    new Dictionary<object, object> {
                        {
                            "question",
                            "What year did Markus 'Notch' Perrson make the video game Minecraft?"},
                        {
                            "answer",
                            "2009"}},
                    new Dictionary<object, object> {
                        {
                            "question",
                            "When did the Nintendo Switch get released To the public?"},
                        {
                            "answer",
                            "2017"}}
                }},
            {
                "Famous People",
                new List<object> {
                    new Dictionary<object, object> {
                        {
                            "question",
                            "What is the date that Micheal Jackson died?"},
                        {
                            "answer",
                            "June 25, 2009"}},
                    new Dictionary<object, object> {
                        {
                            "question",
                            "This famous physicist developed the theory of relativity."},
                        {
                            "answer",
                            "Albert Einstein"}},
                    new Dictionary<object, object> {
                        {
                            "question",
                            "This famous scientist discovered the law of gravity."},
                        {
                            "answer",
                            "Isaac Newton"}}
                }},
            {
                "Television",
                new List<object> {
                    new Dictionary<object, object> {
                        {
                            "question",
                            "What is the name of SpongeBob's best friend in the cartoon, SpongeBob SquarePants?"},
                        {
                            "answer",
                            "Patrick Star"}}
                }},
            {
                "Movies",
                new List<object> {
                    new Dictionary<object, object> {
                        {
                            "question",
                            "This actor played the role of Forrest Gump in the 1994 film of the same name."},
                        {
                            "answer",
                            "Tom Hanks"}}
                }},
            {
                "Books",
                new List<object> {
                    new Dictionary<object, object> {
                        {
                            "question",
                            "This author wrote 'To Kill a Mockingbird'."},
                        {
                            "answer",
                            "Harper Lee"}},
                    new Dictionary<object, object> {
                        {
                            "question",
                            "This author wrote 'The Catcher in the Rye.'"},
                        {
                            "answer",
                            "J.D. Salinger"}}
                }}};
        
        public static object category_order = categories.keys().ToList();
        
        static Module() {
            random.shuffle(category_order);
            intro();
            random.shuffle(questions);
            credits();
        }
        
        public static object questions = categories[category];
        
        public static object answer = input("What is the answer? ");
        
        public static object score = score + 1;
    }
}