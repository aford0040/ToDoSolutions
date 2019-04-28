import React, { useState } from 'react';
import ToDoListItem from './ToDo';

function ToDoList(props)
{
    const [todos, setToDos] = useState({});

    componentDiD

    function GetToDos()
    {

    }

        return (
            <ul>
                {
                    props.ToDoItems.map((content, index) => {
                    return <ToDoListItem toDoItem={content}></ToDoListItem>
                })}
            </ul>
            );        
}

export default ToDoList;