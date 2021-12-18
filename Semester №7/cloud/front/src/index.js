import React from "react"
import ReactDOM from "react-dom"
import Modal from "react-modal"
import { Routes, Route, BrowserRouter } from "react-router-dom"

import Students from "Students"
import Groups from "Groups"
import EditGroups from "EditGroups"
import EditStudents from "EditStudents"

import { getGroups, getStudents, deleteGroup, deleteStudent, updateGroup, updateStudent, addStudent, addGroup } from "crud"

Modal.setAppElement("#root")

function App() {
  return (
    <BrowserRouter>
      <Routes>
        <Route index path="/" element={<Students getStudents={getStudents} getGroups={getGroups} />} />
        <Route path="/students" element={<Students getStudents={getStudents} getGroups={getGroups} />} />
        <Route path="/groups" element={<Groups getStudents={getStudents} getGroups={getGroups} />} />
        <Route path="/editGroups" element={<EditGroups deleteGroup={deleteGroup} getStudents={getStudents} getGroups={getGroups} updateGroup={updateGroup} addGroup={addGroup} />} />
        <Route path="/editStudents/:groupId" element={<EditStudents deleteStudent={deleteStudent} getStudents={getStudents} getGroups={getGroups} updateStudent={updateStudent} addStudent={addStudent} />} />
      </Routes>
    </BrowserRouter>
  )
}

ReactDOM.render(
  <App />,
  document.getElementById("root")
)
