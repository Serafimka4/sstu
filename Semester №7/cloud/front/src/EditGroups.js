import React from "react"
import Modal from "react-modal"
import { Link } from "react-router-dom"

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
      <div><input id="group.name" type="text" placeholder="Name" /></div>
      <div><input id="group.course" type="text" placeholder="Course" /></div>
      <div><input id="group.type" type="text" placeholder="Type" /></div>
      <div><button onClick={update}>Update</button></div>
    </Modal>
  )
}

export default function EditGroups({ getGroups, getStudents, deleteGroup, updateGroup, addGroup }) {
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
  if (localStorage.getItem("groupId") === undefined)
    localStorage.setItem("groupId", -1)

  const updateCurrentGroup = () => {
    const newGroup = {
      "name": document.getElementById("group.name").value,
      "course": document.getElementById("group.course").value,
      "type": document.getElementById("group.type").value
    }

    updateGroup(localStorage.getItem("groupId"), newGroup)

    // Наверное, это бред… Но работает.
    setState({
      ...state,
      groups: getGroups(),
      students: getStudents()
    })

    closeModal()
  }

  const addGroupSubmit = () => {
    const newGroup = {
      name: document.getElementById("newGroup.name").value,
      course: Number(document.getElementById("newGroup.course").value),
      type: document.getElementById("newGroup.type").value,
    }

    addGroup(newGroup)
  }

  if (!state.groups || !state.students || state.groups.length == 0)
    return (
    <>
      <div><Link to="/students">Students</Link></div>
      <div><Link to="/editGroups">Edit</Link></div>

      <ModalWrapper open={state.modalIsOpen} close={closeModal} update={updateCurrentGroup} />

      <table>
        <thead>
          <tr>
            <td>ID</td>
            <td>Name</td>
            <td>Course</td>
            <td>Type</td>
            <td>Students</td>
            <td>Update</td>
            <td>Delete</td>
          </tr>
        </thead>

        <tbody>
        </tbody>
      </table>

      <div><input type="text" id="newGroup.name" placeholder="Name" /></div>
      <div><input type="text" id="newGroup.course" placeholder="Course" /></div>
      <div><input type="text" id="newGroup.type" placeholder="Type" /></div>
      <div><button onClick={addGroupSubmit}>Add</button></div>
    </>
  )

  return (
    <>
      <div><Link to="/students">Students</Link></div>
      <div><Link to="/editGroups">Edit</Link></div>

      <ModalWrapper open={state.modalIsOpen} close={closeModal} update={updateCurrentGroup} />

      <table>
        <thead>
          <tr>
            <td>ID</td>
            <td>Name</td>
            <td>Course</td>
            <td>Type</td>
            <td>Students</td>
            <td>Update</td>
            <td>Delete</td>
          </tr>
        </thead>

        <tbody>
          {
            (() => {
              if (state.groups.map === undefined)
                return <></>

              if (state.students.map === undefined)
                return <></>
              return state.groups.map((g, i) => {
                const deleteCurrentGroup = () => {
                  deleteGroup(g.id)

                  // Наверное, это бред… Но работает.
                  setState({
                    ...state,
                    groups: getGroups(),
                    students: getStudents()
                  })
                }

                const openModalForCurrentGroup = () => {
                  localStorage.setItem("groupId", g.id)
                  openModal()
                }

                return (
                  <tr key={i}>
                    <td>{g.id}</td>
                    <td>{g.name}</td>
                    <td>{g.course}</td>
                    <td>{g.type}</td>
                    <td>
                      <Link to={`/editStudents/${g.id}`}>Students</Link>
                    </td>
                    <td>
                      <button onClick={openModalForCurrentGroup}>Update</button>
                    </td>
                    <td>
                      <button onClick={deleteCurrentGroup}>Delete</button>
                    </td>
                  </tr>
                )
              })
            })()
          }
        </tbody>
      </table>

      <div><input type="text" id="newGroup.name" placeholder="Name" /></div>
      <div><input type="text" id="newGroup.course" placeholder="Course" /></div>
      <div><input type="text" id="newGroup.type" placeholder="Type" /></div>
      <div><button onClick={addGroupSubmit}>Add</button></div>
    </>
  )
}
