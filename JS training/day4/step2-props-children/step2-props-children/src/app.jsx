import { Component, PureComponent } from "react";
import Child from "./child";
import ChildFun from "./funchild";

class App extends PureComponent{
    state = {
        ver : 101,
        power : 1,
        show : true
    }
    increaseVerion = ()=>{
        this.setState({
            ver : this.state.ver+1
        })
    }
    increasePower = ()=>{
        this.setState({
            power : this.state.power+1
        })
    }
    setPower = ()=>{
        this.setState({
            power : 10
        })
    }
    
    componentDidMount(){
        console.log("App's componentDidMount was called")
    }
    componentDidUpdate(){
        console.log("App's componentDidUpdate was called")
    }
    componentWillUnmount(){
        console.log("App's componentWillUnmount was called")
    }
    constructor(){
        super();
        console.log("App's constructor was called")
    }
    render(){
        console.log("App's render was called")
        return <div>
                    <h2>App Component</h2>
                    <button onClick={this.increaseVerion}>Increase Version</button>
                    <button onClick={this.increasePower}>Increase Power</button>
                    <button onClick={this.setPower}>Set Power to 10</button>
                    <button onClick={ ()=> this.setState({ show : !this.state.show })}>Show / Hide</button>
                    { this.state.show && <Child power={ this.state.power } version={ this.state.ver }/> }
                    { this.state.show && <ChildFun power={ this.state.power } version={ this.state.ver }/> }
               </div>
    }
}
export default App;