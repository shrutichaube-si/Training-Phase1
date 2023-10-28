import axios from "axios";
import { useEffect, useState, memo  } from "react"; 

function ChildFun(props){
    // useEffect(); // componentDidMount
    // useEffect(); // componentDidUpdate
    // useEffect(); // componentWillUnmount
   // console.log( useState());
   let [users, setUsers ] = useState([])
    useEffect(function(){
        console.log("Child's componentDidMount was called");
        axios.get("https://jsonplaceholder.typicode.com/users")
        .then( res => setUsers(res.data))
        .catch( err => console.log("Error ", err ))
    },[]);
    useEffect(function(){
        // componentDidUpdate
        console.log("ChildFun's componentDidUpdate was called");
    },[props.version, props.power, users]);
    // useEffect(function(){
    //    return function(){
    //      // componentWillUnmount
    //      console.log("ChildFun's componentWillUnmount was called");
    //    }
    // },[]);

    // useEffect(function(){
    //     // componentDidMount;
    //     console.log("ChildFun's componentDidMount was called");
    //     return function(){
    //         // componentWillUnmount
    //         console.log("ChildFun's componentWillUnmount was called");
    //       }
    // },[props.version]);

    return <div>
            <h2>Function Child Component</h2>
            <h3>Version { props.version }</h3>
            <h3>Power { props.power }</h3>
            <ol>
                {
                    users.map((user, idx) => <li key={idx}>{ user.name }</li>)
                }
            </ol>
           </div>
} 
export default memo(ChildFun);
