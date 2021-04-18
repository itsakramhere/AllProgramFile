# Palindrome.cs
Write a function that checks if a given word is a palindrome. Character case should be ignored.

![alt text](https://user-images.githubusercontent.com/45992595/115144493-9f07d400-a06a-11eb-9fba-90a378efcc92.png)
<hr>

#ChangeDirectory.cs
Write a function that provides a change directory (cd) function for an abstract file system.
 
Notes:
Root path is '/'.
Path separator is '/'.
Parent directory is addressable as '..'.
Directory names consist only of English alphabet letters (A-Z and a-z).
The function should support both relative and absolute paths.
The function will not be passed any invalid paths.
Do not use built-in path-related functions.
 
For example:
path = Path('/a/b/c/d')
path.cd('../x')
print(path.current_path)

