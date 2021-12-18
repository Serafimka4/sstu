import { useState, useEffect } from 'react'
import { Link } from "react-router-dom"

export default function Students({ getStudents, getGroups }) {
  const [state, setState] = useState(null)

  useEffect(() => {
     async function fetchData() {
         setState({
           students: await getStudents(),
           groups: await getGroups()
         })
     }

     fetchData()
  }, [getStudents, getGroups])

  const getGroupNameById = (id) => state.groups.find((g) => g.id === id).name

  if (state === null)
    return <></>

  return (
    <>
      <div><Link to="/groups">Groups</Link></div>
      <div><Link to="/editGroups">Edit</Link></div>

      <table>
        <thead>
          <tr>
            <td>ID</td>
            <td>Name</td>
            <td>Age</td>
            <td>Group</td>
            <td>Type</td>
            <td>Avg. grade</td>
          </tr>
        </thead>

        <tbody>
          {
            state.students.map((s, i) => {
              return (
                <tr key={i}>
                  <td>{s.id}</td>
                  <td>{s.name}</td>
                  <td>{s.age}</td>
                  <td>{getGroupNameById(s.group_id)}</td>
                  <td>{s.type}</td>
                  <td>{s.avg_grade}</td>
                </tr>
              )
            })
          }
        </tbody>
      </table>
    </>
  )
}
