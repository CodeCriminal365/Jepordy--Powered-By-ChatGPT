import random
score = 0

def intro():
    readme = open("readme.txt", "r")
    print("             Intro              ")
    print("================================")
    print(" ")
    print(readme.read())
    print(" ")
    print("================================")

def credits():
    print(" ")
    print("Your Score Is:", score, "Out Of 13 Questions!")
    credits = open("credits.txt", "r")
    print(" ")
    print(credits.read())
    print(" ")
    print("================================")
# Create a list of categories and their corresponding questions and answers
categories = {
    "History": [
        {"question": "What year did World War I start?", "answer": "1914"},
        {"question": "Who was the first president of the United States?", "answer": "George Washington"},
        {"question": "What year did the American Civil War end?", "answer": "1865"}
    ],
    "Science": [
        {"question": "What is the largest planet in our solar system?", "answer": "Jupiter"},
        {"question": "What is the smallest bone in the human body?", "answer": "Stapes"},
        {"question": "What is the symbol for the element oxygen?", "answer": "O"}
    ],
    "Geography": [
        {"question": "What is the capital of Japan?", "answer": "Tokyo"},
        {"question": "What is the largest country in the world?", "answer": "Russia"},
        {"question": "What is the smallest continent?", "answer": "Australia"}
    ],
    "Games": [
        {"question": "What year did Markus 'Notch' Perrson make the video game Minecraft?", "answer": "2009"},
        {"question": "When did the Nintendo Switch get released To the public?", "answer": "2017"}
    ],
    "Famous People": [
        {"question": "What is the date that Micheal Jackson died?", "answer": "June 25, 2009"}
    ],
    "Television": [
        {"question": "What is the name of SpongeBob's best friend in the cartoon, SpongeBob SquarePants?", "answer": "Patrick Star"}
    ]
}

# Shuffle the order of the categories
category_order = list(categories.keys())
random.shuffle(category_order)
intro()
print(" ")
# Loop through the categories and their questions
for category in category_order:
    print(category)
    print("=============")
    questions = categories[category]
    random.shuffle(questions)
    for question in questions:
        print(question["question"])
        answer = input("What is the answer? ")
        if answer.lower() == question["answer"].lower():
            print("Correct!")
            score = score + 1
        else:
            print("Incorrect. The answer is", question["answer"])
        print(" ")
credits()

