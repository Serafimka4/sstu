import { useState, useEffect } from 'react'
import { Link } from "react-router-dom"

export default function Groups({ getGroups }) {
  const [state, setState] = useState(null)

  useEffect(() => {
     async function fetchData() {
         setState({
           groups: await getGroups()
         })
     }

     fetchData()
  }, [getGroups])

  if (state === null)
    return <></>

  return (
    <>
      <div><Link to="/students">Students</Link></div>
      <div><Link to="/editGroups">Edit</Link></div>

      <table>
        <thead>
          <tr>
            <td>ID</td>
            <td>Name</td>
            <td>Course</td>
            <td>Type</td>
          </tr>
        </thead>

        <tbody>
          {
            state.groups.map(function (g, i) {
              return (
                <tr key={i}>
                  <td>{g.id}</td>
                  <td>{g.name}</td>
                  <td>{g.course}</td>
                  <td>{g.type}</td>
                </tr>
              )
            })
          }
        </tbody>
      </table>
    </>
  )
}
