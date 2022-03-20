# SpreadsheetApp

Sharable SpreadsheetApp GUI representation of this project: https://github.com/Eldar-Ka/SharableSpreadSheet-Simulator
Made using .NET WinForms App Framework

Please place the **spreadsheet.dat** file in the path: "*C:\Users\user\source\repos\SpreadsheetApp\SpreadsheetApp\bin\Debug\net5.0-windows*"

The spreadsheet supports several elementary operations.

-The spreadsheet represent a table of n*m cells (n=rows, m=columns).

-Each cell holds a string 

-The speardsheet starts at cell 1,1 (top, left).

![1](https://user-images.githubusercontent.com/81243998/159171745-6d0470b0-e856-404f-af8f-b0b23b2caca4.jpg)

### SpreadSheet section:
Simply displays the SpreadSheet ones it's loaded (Load button+ File text box)

----------------------------------------------------------------------------------
### Single type input operations section: 
This section contains all the operations the requires a **single set** of input.

----------------------------------------------------------------------------------

#### Load: 
The load button loads the data from the "spreadsheet.dat" which is given in the File text box below it (absolute path or relative path) into the dataGridView. An incorrect path will show an error MessageBox.
![2](https://user-images.githubusercontent.com/81243998/159172318-676deab4-fdfe-49f1-ab0e-5c3205737d24.png)

#### Save: 
The save button saves the dataGridView into the "spreadsheet.dat" file and displays a MessageBox accordingly.

#### Get Cell: 
This button requires valid input in the Row and Column text boxes and displays a MessageBox accordingly.
![3](https://user-images.githubusercontent.com/81243998/159172638-c9cdf8d5-68db-42fa-be37-0dcdf6eaf827.png)

#### Set Cell: 
This button requires valid input in the Row, Column and text, textboxes and displays a MessageBox accordingly.
![4](https://user-images.githubusercontent.com/81243998/159172733-30db0a86-d0db-4c0f-b827-f18a46913fc3.png)

#### Search: 
This button searches the string from the text textbox, and displays its location in the dataGridView (if found) on a MessageBox and an error if its not found in the dataGridView. In addition, if the string is found, it's location will be set to the Row and Column text boxes accordingly. (feature)

![5](https://user-images.githubusercontent.com/81243998/159172923-25bf6488-85e2-4fc0-9e63-cb0e660588d1.png)

#### Search In Row:  
This button searches the string from the text textbox, in row given in the Row textbox , and displays its location in the dataGridView (if found) on a MessageBox and an error if it's not found in the dataGridView. In addition, if the string is found, it's location will be set to the Column textbox accordingly. (feature)

![6](https://user-images.githubusercontent.com/81243998/159173058-13956f67-ca6b-4014-a3c6-60e8a6447e89.png)

#### Search In Column: 
This button searches the string from the text textbox, in column given in the Column textbox, and displays its location in the dataGridView (if found) on a MessageBox and an error if it's not found in the dataGridView. In addition, if the string is found, it's location will be set to the Column textbox accordingly. (feature)

![7](https://user-images.githubusercontent.com/81243998/159173160-3d44fc79-05a8-487f-bcf9-76de5d053b28.png)

----------------------------------------------------------------------------------
### Double type input operations section:
this section contains all the operations the requires a **double set** of input.

----------------------------------------------------------------------------------
#### Exchange Rows: 
This button exchanges the rows in the dataGridView according to the input in Row1 and Row2 teaxtboxes
![8](https://user-images.githubusercontent.com/81243998/159173384-0de0c8f8-cb68-431e-812a-096f2a73ea89.png)

#### Exchange Column: 
This button exchanges the rows in the dataGridView according to the input in Column1 and Column2 teaxtboxes
![9](https://user-images.githubusercontent.com/81243998/159173470-d4e84cfc-d470-4ee9-a209-bafcba592ab9.png)

#### Search In Range: 
This button searches the string from the text textbox, in the range given from Row1 to Row2 textboxes **and** from Column1 to Column2 textboxes, and displays its location in the dataGridView (if found) on a MessageBox and an error if it's not found in the dataGridView.
![10](https://user-images.githubusercontent.com/81243998/159173812-c31c2446-be87-4977-8173-722a3a465b91.png)

----------------------------------------------------------------------------------

### SpreadSheet size operations section: 
contains all the operations that manipulate the size of the SpreadSheet

----------------------------------------------------------------------------------

#### Add Row: 
This button adds a row to the dataGridView after the row given as input int the Row textbox.
![11](https://user-images.githubusercontent.com/81243998/159173963-2926869f-323f-4a6f-adb1-f5826ed77058.png)

#### Add Column: 
This button adds a column to the dataGridView after the column given as input int the Column textbox.
![12](https://user-images.githubusercontent.com/81243998/159174019-855e8639-3e25-4998-b3af-abc22a0990af.png)

#### Get Size: 
This button displays the size of the dataGridView in a MessageBox.

![13](https://user-images.githubusercontent.com/81243998/159174077-932e8943-3742-4496-b012-50a3ea3cd0ea.png)
