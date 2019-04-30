import React, { Component } from 'react'

class ToDoListItem extends Component
{
    

    render(props) 
    { 
        return (
        <li>
            Id: {this.props.id} <br />
            Title: {this.props.title} <br />
            Description: {this.props.description} <br />
            TimeAdded: {this.props.timeAdded}
        </li>
        )
    }
}

export default ToDoListItem