import React, { Component } from 'react'

class ToDoListItem extends Component
{
    

    render(props) 
    { 
        return <li>Thing to do: {this.props.toDoItem}</li>
    }
}

export default ToDoListItem