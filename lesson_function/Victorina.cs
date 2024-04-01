namespace lesson_function{
    class Victorina{
        public bool statusVic = true;
        public string name;
        public int questionAmount;
        public string answer;
        public int cost;
        public Victorina(int questionAmount, string name){
            this.name = name;
            this.questionAmount = questionAmount;
            this.cost = 0;
            string[] answers = new string[questionAmount];
        }

        public string Answer{
            set 
            {
                if (value is string) {
                    //Console.WriteLine("Введите ответ: ")
                    this.answer = value;
                }
            }
            get 
            {
                return this.answer;
            }
        }
    
        Dictionary<int, int> trueAnswers = new Dictionary<int, int>()
        {
            [0] = 1703,
            [1] = 37,
            [2] = 5,

        };
        string[] questions = 
        {
            "В каком году был основан? ",
            "сколько лет было Пушкину, когда он умер? ",
            "Сколько будет стоить биток в 2025 году (в руб)? "
        };
        public void game(){
            for(int i = 0; i < questions.Length; i++){
                Console.Write(questions[i]);
                if (Int32.Parse(Console.ReadLine()) == trueAnswers[i]) this.cost++;
            }
            statusVic = false;
            Console.WriteLine($"Поздравляю, {this.name}! У вас {this.cost} правильных ответов!");
        }




        

    }
}

            //{["В каком году был основан?"] = 1703},
            //{["сколько лет было Пушкину, когда он умер?"] = 37},
            //{["Сколько будет стоить биток в 2025 году (в руб)?"] = 5}