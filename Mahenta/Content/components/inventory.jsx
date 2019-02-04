import React, { Fragment } from 'react';
import { DetailView } from './detail-view.jsx';

export class Inventory extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            showDetailModal: false,
            displayData: [],
        };
        this.setState = this.setState.bind(this);
        this.fetchData = this.fetchData.bind(this);
        this.setData = this.setData.bind(this);
    }

    showModal = (e) => {
        this.setState({ showDetailModal: true })
    }

    hideModal = () => {
        this.setState({ showDetailModal: false })
    }

    // FORM SUBMISSION METHOD
    handleSubmit = (event) => {
        event.preventDefault();
        let newInvItem = { donorID: event.target.donor_id.value, sku: event.target.sku.value, name: event.target.name.value }
        //let donor = event.target.donor_id.value;
        //let skuval = event.target.sku.value;
        //let nameval = event.target.name.value;
        fetch("http://localhost:9456/api/inventory", {
            method: "POST",
            mode: "cors",
            cache: "no-cache",
            credentials: "same-origin",
            headers: {
                "Content-Type": "application/json",
            },
            redirect: "follow",
            referrer: "no-referrer",
            body: JSON.stringify(newInvItem)
        }).then(response => response.json())
        .then(() => this.fetchData());
    }

    fetchData = () => {
        fetch("http://localhost:9456/api/inventory", {
            method: "GET",
            mode: "cors",
            cache: "no-cache",
            credentials: "same-origin",
            headers: {
                "Content-Type": "application/json",
            },
            redirect: "follow",
            referrer: "no-referrer",
        })
        .then(response => response.json())
        .then(data => {
            return this.setData(data);
        })
    }

    setData = (data) => {
        this.setState({displayData: data});
    }

    componentDidMount(){
        this.fetchData();
    }

    // =======================================
    // Methods 
    // componentDidMount() - async call to db for paginated inventory list. Proof of life is full list. 
    // =======================================
    render() {
        // this.fetchData();
        return (
            <div className="Inventory">
                <h2>I am an Inventory dashboard landing page.</h2>
                { console.log(this.state.displayData) }
                { this.state.displayData.map((item, i) => {
                    return (
                        <div key={i} className="invList">
                            <h3>{ item.Sku }</h3>
                        </div>
                    )
                }) }
                <button onClick={this.showModal}>click me to see stuff</button>

                <DetailView show={this.state.showDetailModal} handleClose={this.hideModal}>
                    <p>Text from inventory modal</p>
                    <form className="newItemForm" onSubmit={this.handleSubmit}>
                        <input type="number" name="donor_id" required />
                        <input type="text" name="sku" required />
                        <input type="text" name="name" required />
                        <input type="submit" value="Submit new Item" />
                    </form>
                </DetailView>
            </div>
            // Render as a table with clickable table row 
            // ForEach to render the object into the table. 
        );
    }
}