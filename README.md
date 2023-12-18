# Информационная система «обработка конкурсных заявок»
Данное программное обеспечение разработано для автоматизации такой рутинной работы как обработка конкурсных заявок. Приложение предназначено для работников учреждений, в которых существует конкурсы, в которых участвуют различные люди.

## Содержание
- [Технологии](#технологии)
- [Использование](#использование)
- [Тестирование](#тестирование)
- [Contributing](#contributing)
- [To do](#to-do)
- [Команда проекта](#команда-проекта)

## Технологии
- [VisualStudio 2022](https://visualstudio.microsoft.com/ru/)
- [C#](https://learn.microsoft.com/ru-ru/dotnet/csharp/tour-of-csharp/)
- [.NET 6.0](https://learn.microsoft.com/ru-ru/dotnet/welcome)

## Использование
Для работы с приложением необходимо следующее программное обеспечение:
1.	Microsoft Visual Studio Community 2022
Перед началом работы с Информационной средой «обработка конкурсных заявок» на рабочем месте пользователя необходимо выполнить следующие действия:
1.	Открыть программу Microsoft Visual Studio Community 2022.
2.	Найти программу «Processing_Applications».
3.	Открыть ее.
4.	Нажать на кнопку запуска

Выберите нужную вам вкладку на окне: либо "Данные конкурсанта", либо "Работа конкурсанта"

Потом нажмите кнопку "Открыть файл"

![Снимок экрана 2023-12-09 103431](https://github.com/Lisichnikov/Processing_Applications/assets/117975390/62e71fa0-1ef4-49d1-9072-4e83981aee91)

Итог этого:

![Снимок экрана 2023-12-09 103916](https://github.com/Lisichnikov/Processing_Applications/assets/117975390/a090d80d-4265-402d-a2e1-4ed443716ddd)

![Снимок экрана 2023-12-09 104433](https://github.com/Lisichnikov/Processing_Applications/assets/117975390/a8071003-dcd5-410c-bbe5-bd4a9b07125a)

После вывода файла на окно вы можете либо принять либо отклонить заявку и вывести ее в нужное вам место на компьютере:ъ

![Снимок экрана 2023-12-09 104617](https://github.com/Lisichnikov/Processing_Applications/assets/117975390/5da77e82-af29-4462-ae87-f221e717af62)

## Разработка

### Требования
Для установки и запуска проекта, необходим [VisualStudio 2022](https://visualstudio.microsoft.com/ru/)

## Тестирование
В проекте использовались следующие виды тестирования: Интеграционное

Итоги тестирования:

### Интеграционное тестирование

На рисунке 1 представлен граф программы

![Граф программы](https://github.com/Lisichnikov/Processing_Applications/assets/117975390/f2884d07-a8b5-4365-ac43-56fd176bbbf7)

Рисунок 1 – Граф программы


Тестовые пути:

Т1: 1-2-4-5-7-12;

Т2: 1-2-4-6-7-12;

Т3: 1-3-8-9-11-12;

Т4: 1-3-8-10-11-12;

Т5: 1-3-2-4-5-7-12;

Т6: 1-2-3-8-9-11-12.

Пути: 
Путь 1: Выбор вкладки «Данные конкурсанта», нажатие кнопки «Открыть файл», нажатие кнопки «Принять», вывод текста в файл;

Путь 2: Выбор вкладки «Данные конкурсанта», нажатие кнопки «Открыть файл», нажатие кнопки «Отклонить», вывод текста в файл;

Путь 3: Выбор вкладки «Работа конкурсанта», нажатие кнопки «Открыть файл», нажатие кнопки «Принять», вывод картинки в файл;

Путь 4: Выбор вкладки «Работа конкурсанта», нажатие кнопки «Открыть файл», нажатие кнопки «Отклонить», вывод картинки в файл;

Путь 5: Выбор вкладки «Работа конкурсанта», Выбор вкладки «Данные конкурсанта», нажатие кнопки «Открыть файл», нажатие кнопки «Принять», вывод текста в файл;

Путь 6: Выбор вкладки «Данные конкурсанта», Выбор вкладки «Работа конкурсанта», нажатие кнопки «Открыть файл», нажатие кнопки «Принять», вывод картинки в файл.

### Тест-кейсы
Таблица 1. Тест-кейс открытия конкурсной заявки

![Снимок экрана 2023-12-09 105015](https://github.com/Lisichnikov/Processing_Applications/assets/117975390/1e884ae7-62ee-4d8c-99a5-2c4b22ce5cd4)

Таблица 2. Тест-кейс открытия конкурсной работы

![Снимок экрана 2023-12-09 105135](https://github.com/Lisichnikov/Processing_Applications/assets/117975390/56d384ad-bda8-4fb0-b1db-5d6b5565af6f)

Таблица 3. Тест-кейс принятия заявки

![Снимок экрана 2023-12-09 105203](https://github.com/Lisichnikov/Processing_Applications/assets/117975390/c5cd0015-9214-4a7f-a3fb-fba43c07120f)

Таблица 4. Тест-кейс отклонения заявки

![Снимок экрана 2023-12-09 105253](https://github.com/Lisichnikov/Processing_Applications/assets/117975390/5d8503ba-b69e-4288-b8f9-5e503e4d2ef4)

Таблица 5. Тест-кейс редактирования заявки

![Снимок экрана 2023-12-09 105321](https://github.com/Lisichnikov/Processing_Applications/assets/117975390/d57998a3-f6fe-4388-82a9-d6aa1c2b966d)


## Contributing
Сообщения о багах и ошибках присылать на почту: alexochanel@gmail.com

## FAQ 
### Как найти кнопку "Открыть файл"?
- Она находится на справа сверху на главном окне.
### Где можно установить Visual Studio?
- [На официальном сайте Microsoft](https://visualstudio.microsoft.com/ru/)
### Зачем вы разработали этот проект?
- Знаете, я по своей сути хронический меценат, люблю людей, а следовательно и помогать им добросовестно и бескорыстно, деньги кидать сюда: 1111 2222 3333 4444

## To do
- [x] Реализовать ввод текстового файла на окно
- [x] Реализовать ввод изображения на окно
- [x] Реализовать просмотр этих данных
- [x] Реализовать вывод текста в файл
- [x] Реализовать вывод изображения в файл

## Команда проекта
- [Лисичников Алексей](https://vk.com/alexich4) — Главный разработчик, программист, тестировщик, дизайнер

## Источники
https://metanit.com/sharp/

https://metanit.com/sharp/windowsforms/
