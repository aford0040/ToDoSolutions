import React, { Component } from 'react';
import ToDoListItem from './ToDo';

class ToDoList extends Component
{
    render(props)
    {
        return (
            <ul>
                {this.props.ToDoItems.map((content, index) => {
                    return <ToDoListItem toDoItem={content}></ToDoListItem>
                })}
            </ul>
            );        
    }
}

export default ToDoList;