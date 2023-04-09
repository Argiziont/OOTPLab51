---------------------------------------English

Develop a technical task. Show the decomposition of the task, where some of the tasks should be implemented using generative patterns:
- Iterator. 
- State. 
- Chain of responsibility.

Terms of reference.
To develop a data visualization dashboard that can display different types of data in a visually appealing and interactive manner. The dashboard should allow users to view data trends, patterns, and anomalies, and enable them to customize and filter the data according to their interests. The dashboard should be capable of handling large amounts of data, update in real-time, and be accessible from multiple devices.

1. Create a set of report templates that define the structure of the reports, including any formatting rules, data sources, and visualization options. The templates should be designed in a way that allows them to be extended and customized for different types of reports.

2. Implement a set of concrete report generators that can use the report templates to generate actual reports. The generators should be designed to work with different report formats, such as CSV, PDF, and HTML, and be flexible enough to allow for the customization of the report output.

3. Define a set of filter classes that can be used to extract specific data from the input data sources. The filters should be designed to work with the report templates and be easily extensible to accommodate new data sources and filtering requirements.

4. Develop a mechanism for visualizing the data in the reports, including charts, graphs, and tables. The visualization framework should be flexible enough to allow for the customization of the visual output and should be designed to work with the report templates and data sources.

5. Create a client application that can use the report generator system to produce reports based on user input. The application should allow the user to select the report type, data source, filter options, and visualization format, and then generate the report in the desired format.

Requirements:
- The dashboard should be a web-based interface and built using modern front-end technologies such as React, Redux and D3.js.

- Api should be implemented on Asp.Net, using C# language.

- The dashboard should be responsive and work seamlessly across multiple devices, including desktops, laptops, tablets, and smartphones.

- The dashboard should allow users to upload data in various formats such as CSV, Excel and JSON and display it in various formats such as charts, graphs, tables and maps.

- The dashboard should have a user-friendly interface with intuitive navigation, search, and filtering capabilities.

- The dashboard should have the ability to handle real-time data updates and allow users to set alerts and notifications for specific data events. 
Deliverables:

- C# code that implements the report generator using the Iterator, State, Chain of responsibility templates.

- Unit tests that check the functionality of the report generator.


The code implements the Iterator, State, Chain of responsibility design patterns to create different types of reports with different formats and filters.

This code implements the design pattern called Chain of responsibility, State, Iterator to process different types of reports. The code defines several interfaces and classes that represent various components of report generation, including the report itself (which implements the IReport interface), report data (which implements the IReportData interface), report filters (which implements the IReportFilter interface), and report visualizers (which implements the IReportVisualizer interface).

The IReportHandler interface and its specific implementations (ExcelReportHandler and PDFReportHandler) provide a mechanism for handling different types of reports. 

The HandleReportRequest method of the IReportHandler interface is called using a report object, and specific implementations decide whether they can process the report or pass it on to the next handler in the chain.

The IReportState interface and its specific implementations (InitialReportState, ExcelReportState, and PDFReportState) represent different states of the report generation process and provide a mechanism for applying different parameters and actions depending on the state. The GenerateReport method of the IReportState interface is called using a report object, and specific implementations apply their own specific settings and actions, and then call the GenerateReport method of the next state in the chain.

The ExcelReport and PDFReport classes are specific implementations of the IReport interface that generate Excel and PDF reports, respectively. They take objects that implement the IReportData, IReportFilter, and IReportVisualizer interfaces as constructor arguments and use them to generate a report.

---------------------------------------Українська

Розробити технічне завдання. Покажіть декомпозицію завдання, де частина завдань повинна бути реалізована за допомогою генеративних паттернів:
- Ітератор. 
- Стан. 
- Ланцюжок відповідальності.

Технічне завдання.
Розробити дашборд для візуалізації даних, який може відображати різні типи даних у візуально привабливій та інтерактивній формі. Дашборд повинен дозволяти користувачам переглядати тенденції, закономірності та аномалії даних, а також давати їм можливість налаштовувати та фільтрувати дані відповідно до їхніх інтересів. Дашборд має бути здатним обробляти великі обсяги даних, оновлюватися в режимі реального часу та бути доступним з різних пристроїв.

1. Створіть набір шаблонів звітів, які визначають структуру звітів, включаючи будь-які правила форматування, джерела даних та варіанти візуалізації. Шаблони повинні бути розроблені таким чином, щоб їх можна було розширювати та налаштовувати для різних типів звітів.

2. Реалізувати набір конкретних генераторів звітів, які можуть використовувати шаблони звітів для створення реальних звітів. Генератори повинні працювати з різними форматами звітів, такими як CSV, PDF та HTML, і бути достатньо гнучкими, щоб дозволити кастомізувати висновок звіту.

3. Визначити набір класів фільтрів, які можна використовувати для вилучення певних даних з джерел вхідних даних. Фільтри повинні бути розроблені для роботи з шаблонами звітів і легко розширюватися, щоб пристосовуватися до нових джерел даних і вимог до фільтрації.

4. Розробити механізм візуалізації даних у звітах, включаючи діаграми, графіки та таблиці. Механізм візуалізації має бути достатньо гнучким, щоб дозволити кастомізувати візуальний висновок, і має бути розроблений для роботи з шаблонами звітів та джерелами даних.

5. Створити клієнтську програму, яка може використовувати систему генерації звітів для створення звітів на основі даних, введених користувачем. Додаток повинен дозволяти користувачеві вибрати тип звіту, джерело даних, параметри фільтрації та формат візуалізації, а потім згенерувати звіт у потрібному форматі.

Вимоги:
- Дашборд повинен бути веб-інтерфейсом і побудований з використанням сучасних фронтенд-технологій, таких як React, Redux і D3.js.

- Api має бути реалізовано на Asp.Net з використанням мови C#.

- Дашборд повинен бути адаптивним і безперебійно працювати на різних пристроях, включаючи настільні комп'ютери, ноутбуки, планшети та смартфони.

- Дашборд повинен дозволяти користувачам завантажувати дані в різних форматах, таких як CSV, Excel і JSON, і відображати їх у різних форматах, таких як діаграми, графіки, таблиці і карти.

- Дашборд повинен мати зручний інтерфейс з інтуїтивно зрозумілою навігацією, можливістю пошуку та фільтрації.

- Дашборд повинен мати можливість оновлювати дані в режимі реального часу і дозволяти користувачам встановлювати попередження та сповіщення для певних подій з даними. 
Результати:

- Код на C#, що реалізує генератор звітів з використанням шаблонів Iterator, State, Chain of responsibility.

- Юніт-тести, які перевіряють функціональність генератора звітів.


Код реалізує патерни проектування Iterator, State, Chain of responsibility для створення різних типів звітів з різними форматами та фільтрами.

Цей код реалізує патерн проектування під назвою "Ланцюжок відповідальності, стан, ітератор" для обробки різних типів звітів. У коді визначено декілька інтерфейсів та класів, які представляють різні компоненти генерації звітів, включаючи сам звіт (який реалізує інтерфейс IReport), дані звіту (який реалізує інтерфейс IReportData), фільтри звіту (який реалізує інтерфейс IReportFilter) та візуалізатори звітів (який реалізує інтерфейс IReportVisualizer).

Інтерфейс IReportHandler та його конкретні реалізації (ExcelReportHandler та PDFReportHandler) надають механізм для обробки різних типів звітів. 

Метод HandleReportRequest інтерфейсу IReportHandler викликається за допомогою об'єкта звіту, а конкретні реалізації вирішують, чи можуть вони обробити звіт або передати його наступному обробнику в ланцюжку.

Інтерфейс IReportState та його конкретні реалізації (InitialReportState, ExcelReportState та PDFReportState) представляють різні стани процесу генерації звіту та надають механізм для застосування різних параметрів та дій залежно від стану. Метод GenerateReport інтерфейсу IReportState викликається за допомогою об'єкта звіту, а конкретні реалізації застосовують власні специфічні налаштування та дії, після чого викликають метод GenerateReport наступного стану в ланцюжку.

Класи ExcelReport і PDFReport є специфічними реалізаціями інтерфейсу IReport, які генерують звіти у форматі Excel і PDF відповідно. Вони приймають об'єкти, що реалізують інтерфейси IReportData, IReportFilter і IReportVisualizer, як аргументи конструктора і використовують їх для створення звіту.
