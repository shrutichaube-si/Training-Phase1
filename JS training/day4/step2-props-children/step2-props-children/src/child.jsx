import { Component, PureComponent } from "react";
import axios from "axios";

class Child extends PureComponent{
    state = {
        users : [{ name : "Vijay" }]
    }
    componentDidMount(){
        console.log("Child's componentDidMount was called");
        axios.get("https://jsonplaceholder.typicode.com/users")
        .then( res => this.setState({ users : res.data }))
        .catch( err => console.log("Error ", err ))
    }
    componentDidUpdate(){
        console.log("Child's componentDidUpdate was called")
    }
    componentWillUnmount(){
        console.log("Child's componentWillUnmount was called")
    }
    constructor(){
        super();
        console.log("Child's constructor was called")
    }
    render(){
        console.log("Child's render was called")
        return <div>
                    <h2>Child Component</h2>
                    <h3>Version { this.props.version }</h3>
                    <h3>Power { this.props.power }</h3>
                    <ol>
                    {
                        this.state.users.map((user, idx) => <li key={idx}>{ user.name }</li>)
                    }
                    </ol>
                </div>
    }
}

export default Child;