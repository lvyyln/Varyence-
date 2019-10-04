import React, { Component } from 'react';
import { bindActionCreators } from 'redux';
import { connect } from 'react-redux';
import { Link } from 'react-router-dom';
import { actionCreators } from '../store/Coordinates';


class FetchData extends Component {   

    state = {

        label: ''

    };

    onLabelChange = (e) => {

        this.setState({

            label: e.target.value

        })

    };

    onClickDo = (e) => {

        e.preventDefault();

        const { label } = this.state;

        this.props.requestGeolocationCoordinates(label);

    };

    render() {
        return (
            <div>
                <h1>Coordinates</h1>
                {renderCoordinates(this.props)}

                <input type="text"

                    className="form-control new-todo-label"

                    value={this.state.label}

                    onChange={this.onLabelChange}

                    placeholder="Write some place" />

                <p></p>

                <button type="submit" onClick={this.onClickDo} 

                    className="btn btn-outline-secondary">Find geolocation</button>
            </div>
        );
    }

}



function renderCoordinates(props) {
    
        return (
            <table className='table table-striped'>
                <thead>
                    <tr>
                        <th>Lon</th>
                        <th>Lat</th>
                    </tr>
                </thead>
                <tbody>
                    <tr key={props.coordinates.latitude}>
                        <td>{props.coordinates.latitude}</td>
                        <td>{props.coordinates.longitude}</td>
                        </tr>                   
                </tbody>
            </table>
        );
    
}


export default connect(
    state => state.geolocationCoordinates,
    dispatch => bindActionCreators(actionCreators, dispatch)
)(FetchData);

