# Generator_Ksztaltow
 
Program stworzony do rysowania prostych kształtów z użyciem języka C#.

Lista kształtów możliwych do stworzenia 03.06.2022:
- prostokąt
- trójkąt

Lista kształtów możliwych do stworzenia 24.06.2022:
- prostokąt
- trójkąt
- romb

<h1>Dokumentacja</h1>

Home()
---
Funkcja nie przyjmuje żadnych argumentów, wywołanie powoduje wyświetlenie w konsoli listy kształtów i pozwala na wybranie jednego oraz wywołuje wybraną funkcję.

Rectangle()
---
Funkcja rysująca prostąkąt. Po wywołaniu pyta o wysokość, szerokość i wypełnienie.

Triangle()
---
Podobnie jak funkcja Rectangle() po wywołaniu pyta o aspekty kształtu w tym przypadku ilość poziomów i wypełnienie.

Diamond()
---
Po wywołaniu prosi o podanie wysokości i wypełnienia i tworzy romb.

End()
---
Funkcja wyświetlająca napis końcowy i czekająca na wciśnięcie klawisza. Następnie wywołuje funkcję Home()
