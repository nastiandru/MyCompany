# MyCompany

KONFIGURACJA APLIKACJI
1. Utwórz nową bazę danych pod nazwą MyCompany
2. Zmodifikuj plik appsettings.json ustawiając połączenie do bazy danych 
Data Source - zmień na nazwę swojego połączenia z serwerem bazodanowym oraz jeżeli twoja baza danych nazywa się inaczej niż MyCompany, w miejscu Database- wpisz nazwę bazy danych
3. Otwórz konsolę NuGet i wykonaj migracje komedami:
- add-migration <nazwa-migracji>
- update-database –verbose
4. Następnie można już otworzyć aplikacje
5. Aby dodać, edytować lub usunąć usługi firmy, musisz zalogować się do panelu administracyjnego(Панель адміністратора) za pomocą User ID='sa' Password='sa'
