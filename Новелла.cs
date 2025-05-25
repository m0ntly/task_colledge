namespace Novel
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Создатель: Баканин Максим, Группа: ИПО-21.23");
            Console.WriteLine("Нажмите любую кнопку для продолжения...");
            Console.ReadKey();
            StartNovel();
        }

        static void StartNovel()
        {
            Console.Clear();
            Console.WriteLine("Добро пожаловать в 'Космическое Приключение'!");
            Console.WriteLine("Нажмите любую кнопку для продолжения...");
            Console.ReadKey();
            Console.Clear();
            Game();
        }

        static void Game()
        {
            try
            {
                Console.WriteLine("Год 2245. Вы - капитан космического корабля 'Пионер', исследующего сектор Омега.");
                Console.WriteLine("Внезапно ваш корабль получает странный сигнал с планеты X-427.");
                Console.WriteLine("Сканеры показывают аномальные энергетические показатели на поверхности.");

                Console.WriteLine("\nЧто вы предпримете?");
                Console.WriteLine("1. Отправить исследовательский дрон");
                Console.WriteLine("2. Спуститься на планету с командой");
                Console.WriteLine("3. Игнорировать сигнал");
                Console.WriteLine("4. Отправить запрос на установление контакта");
                Console.WriteLine("5. Активировать защитные системы");

                int choice1 = Convert.ToInt32(Console.ReadLine());

                if (choice1 == 1)
                {
                    Console.WriteLine("\nДрон обнаруживает древние руины с голубым свечением.");
                    Console.WriteLine("В центре находится артефакт неизвестной технологии.");

                    Console.WriteLine("\nКак поступить дальше?");
                    Console.WriteLine("1. Отправить команду для исследования");
                    Console.WriteLine("2. Попытаться дистанционно активировать артефакт");
                    Console.WriteLine("3. Собрать образцы для анализа");
                    Console.WriteLine("4. Установить защитный периметр");
                    Console.WriteLine("5. Покинуть планету");

                    int choice2 = Convert.ToInt32(Console.ReadLine());
                    if (choice2 == 1)
                    {
                        Console.WriteLine("\nВаша команда активирует портал в другую галактику.");
                        Console.WriteLine("Вы становитесь первыми межгалактическими путешественниками!");
                        Varible.end = "Концовка: Первопроходцы новой эры";
                        Final();
                    }
                    else if (choice2 == 2)
                    {
                        Console.WriteLine("\nАртефакт передаёт чертежи передовых технологий.");
                        Console.WriteLine("Человечество совершает технологический скачок.");
                        Varible.end = "Концовка: Технологическое откровение";
                        Final();
                    }
                    else if (choice2 == 3)
                    {
                        Console.WriteLine("\nОбразцы содержат неизвестные науке элементы.");
                        Console.WriteLine("Ваше открытие революционизирует физику.");
                        Varible.end = "Концовка: Научный прорыв";
                        Final();
                    }
                    else if (choice2 == 4)
                    {
                        Console.WriteLine("\nПри установке периметра артефакт неожиданно активируется.");
                        Console.WriteLine("Ваш корабль телепортируется в неизвестную точку вселенной.");
                        Varible.end = "Концовка: Неожиданный прыжок";
                        Final();
                    }
                    else if (choice2 == 5)
                    {
                        Console.WriteLine("\nВы покидаете планету, но сигнал начинает преследовать ваш корабль.");
                        Console.WriteLine("Он изменяет ваши навигационные системы...");
                        Varible.end = "Концовка: Таинственный сигнал";
                        Final();
                    }
                }
                else if (choice1 == 2)
                {
                    Console.WriteLine("\nВы находите руины древней цивилизации.");
                    Console.WriteLine("Голографические записи содержат предупреждение.");

                    Console.WriteLine("\nКак поступить?");
                    Console.WriteLine("1. Изучить записи полностью");
                    Console.WriteLine("2. Восстановить энергосистему руин");
                    Console.WriteLine("3. Эвакуироваться с планеты");
                    Console.WriteLine("4. Отправить данные на Землю");
                    Console.WriteLine("5. Попытаться найти выживших");

                    int choice3 = Convert.ToInt32(Console.ReadLine());
                    if (choice3 == 1)
                    {
                        Console.WriteLine("\nЗаписи содержат информацию о смертельном вирусе.");
                        Console.WriteLine("Вы можете предупредить человечество.");
                        Varible.end = "Концовка: Предупреждён - значит вооружён";
                        Final();
                    }
                    else if (choice3 == 2)
                    {
                        Console.WriteLine("\nПри восстановлении энергии пробуждаются древние защитные системы.");
                        Console.WriteLine("Руины начинают атаковать ваш корабль!");
                        Varible.end = "Концовка: Пробуждение древних";
                        Final();
                    }
                    else if (choice3 == 3)
                    {
                        Console.WriteLine("\nПри попытке эвакуации обнаруживается гравитационная аномалия.");
                        Console.WriteLine("Вам удаётся сбежать с большими потерями.");
                        Varible.end = "Концовка: Опасная эвакуация";
                        Final();
                    }
                    else if (choice3 == 4)
                    {
                        Console.WriteLine("\nДанные позволяют расшифровать язык древней цивилизации.");
                        Console.WriteLine("Вы становитесь самым известным лингвистом галактики.");
                        Varible.end = "Концовка: Лингвистический прорыв";
                        Final();
                    }
                    else if (choice3 == 5)
                    {
                        Console.WriteLine("\nВы находите в криокамере последнего представителя расы.");
                        Console.WriteLine("Он становится вашим проводником по галактике.");
                        Varible.end = "Концовка: Последний из своего рода";
                        Final();
                    }
                }
                else if (choice1 == 3)
                {
                    Console.WriteLine("\nВы продолжаете свой путь, но сигнал усиливается.");
                    Console.WriteLine("Он начинает влиять на системы корабля...");

                    Console.WriteLine("\nЧто будете делать?");
                    Console.WriteLine("1. Ускориться и попытаться уйти");
                    Console.WriteLine("2. Отправить сообщение о помощи");
                    Console.WriteLine("3. Закрыть все коммуникационные системы");
                    Console.WriteLine("4. Развернуть корабль для исследования");
                    Console.WriteLine("5. Активировать протокол самоуничтожения");

                    int choice4 = Convert.ToInt32(Console.ReadLine());
                    if (choice4 == 1)
                    {
                        Console.WriteLine("\nСигнал оказывается гравитационной аномалией.");
                        Console.WriteLine("Вам удаётся вырваться в последний момент.");
                        Varible.end = "Концовка: Гравитационный побег";
                        Final();
                    }
                    else if (choice4 == 2)
                    {
                        Console.WriteLine("\nВаш сигнал привлекает внимание неизвестного корабля.");
                        Console.WriteLine("Он оказывается разведчиком древней цивилизации!");
                        Varible.end = "Концовка: Неожиданный контакт";
                        Final();
                    }
                    else if (choice4 == 3)
                    {
                        Console.WriteLine("\nИзоляция спасает ваш корабль, но вы теряете ориентацию.");
                        Console.WriteLine("Вы дрейфуете в неизвестном направлении...");
                        Varible.end = "Концовка: Потерянные в космосе";
                        Final();
                    }
                    else if (choice4 == 4)
                    {
                        Console.WriteLine("\nПри приближении вы обнаруживаете целую сеть таких сигналов.");
                        Console.WriteLine("Это оказывается галактическая система навигации!");
                        Varible.end = "Концовка: Карта галактики";
                        Final();
                    }
                    else if (choice4 == 5)
                    {
                        Console.WriteLine("\nВ последний момент сигнал исчезает.");
                        Console.WriteLine("Вы остаётесь в живых, но с повреждённым кораблём.");
                        Varible.end = "Концовка: На грани уничтожения";
                        Final();
                    }
                }
                else if (choice1 == 4)
                {
                    Console.WriteLine("\nВаш запрос получает ответ на неизвестном языке.");
                    Console.WriteLine("Компьютер начинает автоматический перевод...");

                    Console.WriteLine("\nКак реагировать?");
                    Console.WriteLine("1. Отправить математические последовательности");
                    Console.WriteLine("2. Передать изображения Земли");
                    Console.WriteLine("3. Запросить координаты источника");
                    Console.WriteLine("4. Перейти на защищённую частоту");
                    Console.WriteLine("5. Прекратить контакт");

                    int choice5 = Convert.ToInt32(Console.ReadLine());
                    if (choice5 == 1)
                    {
                        Console.WriteLine("\nЭто оказывается универсальный язык общения!");
                        Console.WriteLine("Вы устанавливаете первый межзвёздный диалог.");
                        Varible.end = "Концовка: Первый контакт";
                        Final();
                    }
                    else if (choice5 == 2)
                    {
                        Console.WriteLine("\nВ ответ приходят изображения их мира.");
                        Console.WriteLine("Начинается культурный обмен между цивилизациями.");
                        Varible.end = "Концовка: Культурный мост";
                        Final();
                    }
                    else if (choice5 == 3)
                    {
                        Console.WriteLine("\nКоординаты ведут к заброшенной космической станции.");
                        Console.WriteLine("Вы находите там технологии, опережающие земные на века.");
                        Varible.end = "Концовка: Технологическая сокровищница";
                        Final();
                    }
                    else if (choice5 == 4)
                    {
                        Console.WriteLine("\nНа защищённой частоте вы обнаруживаете военный канал.");
                        Console.WriteLine("Это оказывается граница враждующих межзвёздных империй!");
                        Varible.end = "Концовка: Опасное соседство";
                        Final();
                    }
                    else if (choice5 == 5)
                    {
                        Console.WriteLine("\nПрервав контакт, вы не замечаете, как к вам приближается корабль.");
                        Console.WriteLine("Он блокирует ваши двигатели...");
                        Varible.end = "Концовка: Нежелательное внимание";
                        Final();
                    }
                }
                else if (choice1 == 5)
                {
                    Console.WriteLine("\nПри активации защиты сигнал изменяется.");
                    Console.WriteLine("Он начинает имитировать земные коммуникационные протоколы...");

                    Console.WriteLine("\nВаши действия?");
                    Console.WriteLine("1. Просканировать источник сигнала");
                    Console.WriteLine("2. Отправить тестовое сообщение");
                    Console.WriteLine("3. Начать запись для анализа");
                    Console.WriteLine("4. Перенаправить сигнал на Землю");
                    Console.WriteLine("5. Усилить защитное поле");

                    int choice6 = Convert.ToInt32(Console.ReadLine());
                    if (choice6 == 1)
                    {
                        Console.WriteLine("\nСканирование выявляет искуственный интеллект.");
                        Console.WriteLine("Он предлагает вам союз против неизвестной угрозы.");
                        Varible.end = "Концовка: Неожиданный союзник";
                        Final();
                    }
                    else if (choice6 == 2)
                    {
                        Console.WriteLine("\nВ ответ приходит код, открывающий доступ к архивным данным.");
                        Console.WriteLine("Вы узнаёте истинную историю галактики.");
                        Varible.end = "Концовка: Историческое откровение";
                        Final();
                    }
                    else if (choice6 == 3)
                    {
                        Console.WriteLine("\nАнализ показывает, что сигнал - это предупреждение.");
                        Console.WriteLine("Вы предотвращаете катастрофу земного масштаба!");
                        Varible.end = "Концовка: Спаситель человечества";
                        Final();
                    }
                    else if (choice6 == 4)
                    {
                        Console.WriteLine("\nЗемные учёные расшифровывают сигнал.");
                        Console.WriteLine("Оказывается, это послание от будущего человечества!");
                        Varible.end = "Концовка: Послание через время";
                        Final();
                    }
                    else if (choice6 == 5)
                    {
                        Console.WriteLine("\nУсиление поля вызывает обратную реакцию.");
                        Console.WriteLine("Сигнал усиливается и проникает во все системы...");
                        Varible.end = "Концовка: Обратный эффект";
                        Final();
                    }
                }
                else
                {
                    Console.WriteLine("\nВаше бездействие приводит к потере сигнала.");
                    Console.WriteLine("Возможность первого контакта упущена навсегда.");
                    Varible.end = "Концовка: Упущенные возможности";
                    Final();
                }
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine(ex.Message);
                Console.WriteLine("\nНажмите любую кнопку для продолжения...");
                Console.ReadKey();
                Restart();
            }
        }

        static void Final()
        {
            Console.Clear();
            Console.WriteLine(Varible.end);
            Console.WriteLine("\nВведите 1, чтобы начать заново, или любую другую клавишу для выхода:");
            try
            {
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    Restart();
                }
                else
                {
                    Console.WriteLine("\nСпасибо за игру! До новых встреч среди звёзд!");
                }
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Спасибо за игру! До новых встреч среди звёзд!");
            }
        }

        static void Restart()
        {
            StartNovel();
        }
    }

    class Varible
    {
        public static String end;
    }
}
