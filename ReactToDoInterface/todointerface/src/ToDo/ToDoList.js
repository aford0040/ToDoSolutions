import React, { useState } from 'react';
import ToDoListItem from './ToDo';

function ToDoList(props)
{
    const [todos, setToDos] = useState(
    () => 
    fetch('http://localhost:52503/api/get/todos')
    .then(response => response.json())
    .then(data =>{
        console.log(data);
        setToDos(data)})
    );

    return (
        <ul>
            
                <ToDoListItem todoItem={todos[0]}></ToDoListItem>
        </ul>
    );        
}

export default ToDoList;