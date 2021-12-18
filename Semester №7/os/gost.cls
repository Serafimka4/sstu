\NeedsTeXFormat{LaTeX2e}[1994/06/01]
\ProvidesClass{gost}[2020/02/28 0.1.0 GOST 3.72-2017 support for LaTeX]

% Устанавливаем размер шрифта в 14 пунктов.
% Рекомендованный размер шрифта по ГОСТ 7.32-2017 ---
% не менее 12 пунктов [1, §́ 6.1.1].
\LoadClass[14pt,russian]{extarticle}

% Настройка формат страниц и величины полей согласно [1, § 6.1.1].
\usepackage[
	a4paper,
	bindingoffset=0pt,
	left=30mm,
	right=15mm,
	top=20mm,
	bottom=20mm,
	footskip=0mm,
	includeheadfoot,
]{geometry}

% Просим LaTeX попытаться избежать строк- «сирот» и «вдов».
\usepackage[all]{nowidow}

% Поддержка кириллицы и кодировки UTF-8.
\usepackage[T1,T2A]{fontenc}
\usepackage[utf8]{inputenc}
\usepackage[english,main=russian]{babel}

% Поддержка вставки изображений в документ.
\usepackage{graphicx}
\graphicspath{{img/}}

% Центрируем подписи под рисунком.
% TODO: добавить ссылку на ГОСТ.
\usepackage[justification=centering]{caption}

% Плавающее положение изображений в документе.
\usepackage{float}

% Из ГОСТ.32-2017: «Иллюстрации при необходимости могут иметь наименование и
% пояснительные данные (подрисуночный текст). Слово "Рисунок", его номер и через
% тире наименование помещают после пояснительных данных и располагают в центре
% под рисунком без точки в конце» [1, 6.5.7].
%
% TODO: заменить en dash (короткое тире) на em dash (тире).
\usepackage[figurename=Рисунок,labelsep=endash]{caption}

% Из ГОСТ.32-2017: «Допускается нумеровать иллюстрации в пределах раздела
% отчета. В этом случае номер иллюстрации состоит из номера раздела и
% порядкового номера иллюстрации, разделенных точкой: Рисунок 2.1.» [1, 6.5.6].
\renewcommand{\thefigure}{\arabic{section}.\arabic{figure}}

% Поддержка автоматических переносов слов.
\usepackage{hyphenat}

% Из ГОСТ 7.32-2017: "Страницы отчета следует нумеровать арабским
% цифрами, соблюдая сквозную нумерацию по всему тексту отчета,
% включая приложения" [1, § 6.3.1].
\pagenumbering{arabic}

% Рекомендуемый по ГОСТ 7.32-2017 тип шрифта для основного текста отчета - Times
% New Roman [1, § 6.1.1].
%
% Способ задания шрифта Times New Roman с поддержкой кириллицы подсмотрен в
% источнике [2].
\usepackage{tempora}

% Полуторный интервал рекомендован [1, § 6.1.1].
\usepackage{setspace}
\onehalfspacing

% ГОСТ 7.32-2017: "Абзацный отступ должен быть одинаковым по всему
% тексту отчета и равен 1,25 см." [1, § 6.1.1].
\setlength{\parindent}{1.25cm}

% LaTeX по-умолчанию выравнивает текст по ширине, что и требуется по
% ГОСТ.32-2017.
% TODO: привести ссылку на требование.

% Формат заголовков: размер шрифта, интерлиньяж и расстояние между
% порядковым номером и сами заголовком. Последнее берется равным абзацному
% отступу (1,25 см).
%
% TODO: найти, какие требования к оформлению заголовков предъявляет [1].
\usepackage{titlesec}
\titleformat{\section}{\normalfont\fontsize{16pt}{\baselineskip}\bfseries}{\thesection}{1.25cm}{}
\titleformat{\subsection}{\normalfont\fontsize{15pt}{\baselineskip}\bfseries}{\thesubsection}{1.25cm}{}
\titleformat{\subsubsection}{\normalfont\fontsize{14pt}{\baselineskip}\bfseries}{\thesubsubsection}{1.25cm}{}

% Задаем тире как символ для элементов в списках.
% TODO: найти, какие требования предъявляет [1] к оформлению списков.
\renewcommand{\labelitemi}{---}

% Поддержка библиографического списока по ГОСТ 7.0.5-2008.
% https://github.com/odomanov/biblatex-gost
\usepackage[autostyle]{csquotes}
\selectlanguage{russian}
\usepackage[backend=biber,style=gost-numeric,sorting=ynt]{biblatex}
\addbibresource{bibliography.bib}

% Из ГОСТ.32-2017: «Заголовки структурных элементов следует располагать в
% середине строки без точки в конце, прописными буквами, не подчеркивая. Каждый
% структурный элемент и каждый раздел основной части отчета начинают с новой
% страницы» [1, § 6.2.1].
\newcommand*\gostStructureElement[1]{
	\clearpage
	\section*{\centerline{\MakeUppercase{#1}}}
	\addcontentsline{toc}{section}{\MakeUppercase{#1}}
}

% Из ГОСТ.32-2017: «Использование курсива допускается для обозначения объектов
% (биология, геология, медицина, нанотехнологии, генная инженерия и др.) и
% написания терминов (например, in vivo, in vitro) и иных объектов и терминов на
% латыни» [1, § 6.1.1].
\newcommand*\obj[1]{\textit{#1}}
\newcommand*\term[1]{\textit{#1}}

% То же, что и выше для содержания.
\usepackage{etoc}
\etocsettocstyle{\centerline{\MakeUppercase{\textbf{Содержание}}}}

%% TODO https://tex.stackexchange.com/questions/410250/understanding-line-height-line-spacing-baselineskip-in-latex
\usepackage{fix-cm}

% Условные выражения в LaTeX.
% TODO: разобраться подробнее, вероятно в LaTeX есть встроенные условия.
\usepackage{etoolbox}

\newcommand{\gostTitlePage}{%
	\begin{titlepage}
		\begin{center}
			\singlespacing

			% Из ГОСТ 3.72-2017: «<…> наименование министерства (ведомства) или
			% другого структурного образования, в систему которого входит
			% организация-исполнитель, следует помещать в верхней части титульного
			% листа одно под другим по центру страницы.
			%
			% Наименование министерства (ведомства) приводят в полном виде с прописной
			% буквы» [1, § 6.10.1].
			Министерство образования и науки Российской Федерации

			% Из ГОСТ 3.72-2017: «Наименование организации-исполнителя НИР
			% приводят прописными буквами, по центру страницы, через один
			% межстрочный интервал» [1, § 6.10.1].
			\MakeUppercase{\universityFullName}

			% Из ГОСТ 3.72-2017: «Сокращенное наименование организации приводят в
			% круглых скобках, на отдельной строке, по центру страницы, прописными
			% буквами, через один межстрочный интервал» [1, § 6.10.1].
			(\universityShortName)

			\vspace{24pt}

			% Кафедра.
			% XXX: нет в ГОСТ.32-2017.
			Кафедра \enquote{\department}

			\vspace{96pt}

			\begingroup
				\singlespacing

				% Вид документа
				ОТЧЕТ О \\
				НАУЧНО-ИССЛЕДОВАТЕЛЬСКОЙ РАБОТЕ

				% Наименование отчета.
				% Считаем, что оно совпадает с наименованием НИР и указыаем только его.
				\MakeUppercase{\nirName}
			\endgroup

			% Вид отчета.
			\ifdefstring{\nirType}{промежуточный}
				{(\nirType, этап \nirStage)}
				{(\nirType)}

			\vspace{24pt}

			% Предмет.
			% XXX: нет в ГОСТ.32-2017.
			\subject
		\end{center}

		\vspace{24pt}

		\begin{flushleft}
			\singlespacing

			Исполнитель НИР,

			студент б1-ПИНФ-41 \_\_\_\_\_\_\_\_\_\_ Нефедов Д.В.

			\singlespacing

			Руководитель НИР,

			канд. техн. наук, доц. \_\_\_\_\_\_\_\_\_\_ Федукин А.Ю

			% \begingroup
			% 	\fontsize{12pt}{1}\selectfont
			% 	\hspace{11em} подпись, дата
			% \endgroup
		\end{flushleft}

		\vfill
		\centerline{Саратов 2021}
	\end{titlepage}

	\newgeometry{
		bindingoffset=0pt,
		left=30mm,
		right=15mm,
		top=20mm,
		bottom=20mm,
		footskip=20mm,
		includeheadfoot}
}

\endinput
