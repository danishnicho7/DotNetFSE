# Lab 2 – Git Ignore

## Objective
- Explain `.gitignore` in Git  
- Learn how to ignore unwanted files using `.gitignore`

## Goal
- Implement `.gitignore` to ignore `.log` files and the `log` folder  
- Ensure these files are excluded from commits to the repository

## Prerequisites
- Git installed on the system  
- GitHub account and repository set up  
- Basic Git commands knowledge  
- Local Git repository already initialized

## Components Used
- **Git** – for version control  
- **GitHub** – for remote repository hosting  
- **VS Code / Notepad++** – for file editing

## Method Used
1. Create a `.log` file (`sample.log`) in the project directory.  
2. Create a `log` folder containing a `.log` file (`debug.log`).  
3. Create a `.gitignore` file with the following content:
   ```gitignore
   *.log
   log/

## Output

After running `git status`, the `.log` files and `log/` folder are ignored

## Conclusion

In this lab, we explored the purpose and usage of the .gitignore file to effectively exclude unwanted files and directories from Git version control. By learning how to create and configure .gitignore, you can keep your repository clean, avoid committing sensitive or unnecessary files, and improve collaboration with other developers. Mastering .gitignore is essential for maintaining efficient and organized Git workflows.