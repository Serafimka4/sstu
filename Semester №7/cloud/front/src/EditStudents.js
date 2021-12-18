import React from "react"
import Modal from "react-modal"
import { Link, useParams } from "react-router-dom"

function ModalWrapper({open, close, update}) {
  const styles = {
    content: {
      top: "50%",
      left: "50%",
      right: "auto",
      bottom: "auto",
      marginRight: "-50%",
      transform: "translate(-50%, -50%)"
    }
  }

  return (
    <Modal isOpen={open} onRequestClose={close} style={styles}>
      <div><input id="student.name" type="text" placeholder="Name" /></div>
      <div><input id="student.type" type="text" placeholder="Type" /></div>
      <div><input id="student.age" type="text" placeholder="Age" /></div>
      <div><input id="student.avg_grade" type="text" placeholder="Avg. Grade" /></div>
      <div><button onClick={update}>Update</button></div>
    </Modal>
  )
}

export default function EditStudents({ getGroups, getStudents, deleteStudent, updateStudent, addStudent }) {
  const [ state, setState ] = React.useState({
    students: null,
    groups: null,
    modalIsOpen: false
  })

  React.useEffect(() => {
     async function fetchData() {
         setState({
           students: await getStudents(),
           groups: await getGroups()
         })
     }

     fetchData()
  }, [getStudents, getGroups])

  const openModal = () => setState({...state, modalIsOpen: true})
  const closeModal = () => setState({...state, modalIsOpen: false})

  // Понять и простить…
  if (localStorage.getItem("studentId") === undefined)
    localStorage.setItem("studentId", -1)

  const GROUP_ID = useParams().groupId

  const updateCurrentStudent = () => {
    const newStudent = {
      name: document.getElementById("student.name").value,
      group_id: GROUP_ID,
      type: document.getElementById("student.type").value,
      age: document.getElementById("student.age").value,
      avg_grade: document.getElementById("student.avg_grade").value
    }

    if (state.groups.find((g) => g.id === newStudent.group_id))
      updateStudent(localStorage.getItem("studentId"), newStudent)

    // Наверное, это бред… Но работает.
    setState({
      ...state,
      groups: getGroups(),
      students: getStudents()
    })

    closeModal()
  }


  const addStudentSubmit = () => {
    const newStudent = {
      name: document.getElementById("newStudent.name").value,
      group_id: /*gid*/GROUP_ID,
      type: document.getElementById("newStudent.type").value,
      age: document.getElementById("newStudent.age").value,
      avg_grade: document.getElementById("newStudent.avg_grade").value
    }

    addStudent(newStudent)
  }

  const getGroupNameById = (id) => state.groups.find((g) => g.id === id).name

  if (state.groups === null || state.students === null)
    return <></>

  // TODO: what the fuck with ===!?
  // eslint-disable-next-line
  const group = state.groups.find((g) => g.id == GROUP_ID)
  const groupStudents = state.students.filter((s) => s.group_id === group.id)

  return (
    <>
      <div><Link to="/students">Students</Link></div>
      <div><Link to="/editGroups">Edit</Link></div>

      <ModalWrapper open={state.modalIsOpen} close={closeModal} update={updateCurrentStudent} />

      <table>
        <thead>
          <tr>
            <td>ID</td>
            <td>Name</td>
            <td>Age</td>
            <td>Group</td>
            <td>Type</td>
            <td>Avg. grade</td>
            <td>Update</td>
            <td>Delete</td>
          </tr>
        </thead>

        <tbody>
          {
            groupStudents.map((s, i) => {
              const deleteCurrentStudent = () => {
                deleteStudent(s.id)

                // Наверное, это бред… Но работает.
                // setState({
                //   ...state,
                //   groups: getGroups(),
                //   students: getStudents()
                // })
              }

              const openModalForCurrentStudent = () => {
                localStorage.setItem("studentId", s.id)
                openModal()
              }

              return (
                <tr key={i}>
                  <td>{s.id}</td>
                  <td>{s.name}</td>
                  <td>{s.age}</td>
                  <td>{getGroupNameById(s.group_id)}</td>
                  <td>{s.type}</td>
                  <td>{s.avg_grade}</td>
                  <td>
                    <button onClick={openModalForCurrentStudent}>Update</button>
                  </td>
                  <td>
                    <button onClick={deleteCurrentStudent}>Delete</button>
                  </td>
                </tr>
              )
            })
          }
        </tbody>
      </table>

      <div><input type="text" id="newStudent.name" placeholder="Name" /></div>
      <div><input type="text" id="newStudent.age" placeholder="Age" /></div>
      <div><input type="text" id="newStudent.avg_grade" placeholder="Avg. grade" /></div>
      <div><input type="text" id="newStudent.type" placeholder="Type" /></div>
      <div><button onClick={addStudentSubmit}>Add</button></div>
    </>
  )
}
