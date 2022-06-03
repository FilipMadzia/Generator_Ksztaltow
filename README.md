# Generator_Ksztaltow
 
Program stworzony do rysowania prostych kształtów z użyciem języka C#.

Lista kształtów możliwych do stworzenia 03.06.2022:
- prostokąt
- trójkąt

===Dokumentacja===

Home()
----------
Funkcja nie przyjmuje żadnych argumentów, wywołanie powoduje wyświetlenie w konsoli listę kształtów i pozwala na wybranie jednego oraz po uzupełnieniu danych wywołuje funkcję wybraną

Rectangle(int width, int height, string inside)
----------
Funkcja rysująca prostąkąt z argumentów. Wywołanie wymaga podania szerokości, wysokości oraz wypełnienia. 

Triangle(int levels, string inside)
---------
Podobnie jak funkcja Rectangle() wymaga podania wypełnienia a dodatkowo liczbę poziomów (levels). Generuje na ich podstawie trójkąt.

End();
----------
Funkcja wyświetlająca napis końcowy i czekająca na wciśnięcie klawisza. Następnie wywołuje funkcję Home()