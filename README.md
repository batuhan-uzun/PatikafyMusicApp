# Patikafy Music Platform - LINQ Practice

This is a C# Console Application designed to demonstrate the use of LINQ queries on a list of singers. Each singer is represented as an object with properties such as name, genre, debut year, and album sales. The program performs various LINQ queries to extract and display information based on specific criteria.

## Features

### Singer List
- A predefined list of singers is created based on the given table.
- Each singer is represented as an object of the `Singer` class with the following properties:
  - **Name**: The name of the singer.
  - **Genre**: The type of music the singer performs.
  - **DebutYear**: The year the singer released their first album.
  - **AlbumSales**: The approximate number of albums sold.

### LINQ Queries
1. Singers whose names start with 'S'.
2. Singers with album sales over 10 million.
3. Singers who debuted before the year 2000 and performed pop music (sorted alphabetically by name and grouped by debut year).
4. The singer with the highest album sales.
5. The most recent and the oldest debut year among all singers.

### Console Output
- The results of each query are displayed in the console.

## How to Run

1. Clone or download the repository.
2. Open the project in an IDE (e.g., Visual Studio, Visual Studio Code).
3. Build and run the project.

## Example Output

```plaintext
Singers whose names start with 'S':
Sertab Erener
Sıla
Serdar Ortaç

Singers with album sales over 10 million:
Ajda Pekkan
Sezen Aksu
Tarkan

Singers who debuted before 2000 and performed pop music:
Ajda Pekkan (1968)
Sezen Aksu (1971)
Sertab Erener (1994)
Serdar Ortaç (1994)
Tarkan (1992)
Gülben Ergen (1997)

Singer with the highest album sales:
Tarkan - Yaklaşık 40 milyon

Singer with the most recent debut year:
Sıla (2009)
Singer with the oldest debut year:
Neşet Ertaş (1960)
```

## Project Structure

- Program.cs      // Contains the main logic of the application

## Concepts Demonstrated
1. Object-Oriented Programming:
   • Encapsulation of singer data in the `Singer` class.
2. LINQ Queries:
   • Filtering (`Where`) and sorting (`OrderBy`, `OrderByDescending`).
   • Grouping and transformation using LINQ.
3. Helper Method:
   • A helper method is used to parse album sales data into numerical values for easier comparison.

## Contribution

Feel free to fork the repository, make improvements, and submit a pull request. Contributions are always welcome!

## License

This project is licensed under the MIT [LICENSE](LICENSE). See the LICENSE file for details.

## Author

Created by Batuhan Uzun.
