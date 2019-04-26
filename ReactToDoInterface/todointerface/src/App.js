import React, { Component } from 'react';
import './App.css';
import ToDoList from './ToDo/ToDoList';

class App extends Component {
  render() {
    return (
      <div className="container">
        <table className="table table-bordered">
          <thead className="table-dark">
            <tr>
              <th>chck</th>
              <th>asfdasdf</th>
            </tr>
          </thead>
          <tbody>
            <tr>
              <td>chcking</td>
              <td>blank Row</td>
            </tr>
          </tbody>
          
        </table>
        <h1>Header</h1>

    <ToDoList ToDoItems= {["some item", "another item", "more items still!!"]} />

      </div>
    );
  }
}

export default App;
