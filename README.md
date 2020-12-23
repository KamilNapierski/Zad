# Kamil Napieralski
Zadania do rozwiązania

Solucja ma w sobie jeden projekt. Z tego należy zrobić program, dodawany w referencjach do pozostałych które należy wykonać zgodnie z opisem:

- Utwórz projekt  (Console app) w danej solucji, 
który wyświetli wyszystkie dokumenty w tabelce z kolumnami (ID, NazwaKontrahenta, KwotaDokumentu) uporządkowane według wartości całego dokumentu (od najwyższej)
- Utwórz projekt  (Windows Forms) w danej solucji, który wyświetli w Gridzie to samo co wyżej, przy czym użytkownik może wskazać w zakresie od 1-100 ilość wyświetlanych dokumentów na danym gridzie
- Utwórz projekt (Windows Forms) w danej solucji, który wyświetli wszystkich kontrahentów, z możliwością wyboru jednego (np. na dwu-klik lub inaczej, według twojego uznania). Po jego wyborze, wyświetli sie lista jego dokumentów
- Napisz API, które:

  - zwróci listę wszystkich dokumentów, razem z ich całkowitą kwotą na endpoincie '/dokumenty'
  - zwróci konkretny dokument, z listą pozycji na endpoincie '/dokumenty/{idDokumentu}'
  - zwróci listę kontrahentów na endpoincie '/kontrahenci'
  - zwróci listę dokumentów według kontrahentów na endpoincie '/dokumentyWgKontrahent/{idKontrahenta}'
